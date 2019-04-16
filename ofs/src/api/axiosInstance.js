import axios from 'axios'
import store from '../store/index'
import { MessageBox } from 'element-ui'

// 请求状态码
const STATUS_CODE = {
  400: '无效的请求',
  401: '登录超时',
  404: '获取的资源不存在',
  500: '服务器内部错误，请联系管理员',
  408: '请求超时'
}

// 反向代理url
const BASE_URL = {
  'development': '/api',
  'production': ''
}
// 设置请求默认参数
axios.defaults.timeout = 10000
axios.defaults.baseURL = BASE_URL[process.env.NODE_ENV]

// 请求拦截
axios.interceptors.request.use(
  config => {
    if (store.state.token) {
      config.headers['Content-Type'] = 'application/json;charset=UTF-8'
      config.headers.Authorization = `Bearer ${store.state.token}`
    }
    return config
  },
  error => {
    // 提示请求超时
    showTimeout()
    return error
  }
)

// 响应拦截
axios.interceptors.response.use(
  response => {
    if (response.data.success) {
      return response.data
    }
  }, (error) => {
    // 弹出错误信息
    showErrorMsg(error)
    return Promise.reject(new Error(JSON.stringify({
      message: error.message,
      status: error.response.data.errCode,
      url: error.request.responseURL
    })))
  })

/**
 * 弹出错误信息
 * @param error [Object] 请求错误对象
 */
function showErrorMsg (error) {
  let errorCode = error.response.data.errCode || error.response.status
  MessageBox.alert(
    error.message,
    STATUS_CODE[errorCode] || '错误',
    {
      type: 'error'
    })
}
/**
 * 弹出请求超时
 */
function showTimeout () {
  MessageBox.alert('请求超时', '请求超时', {
    type: 'warning '
  })
}

// 导出默认的实例
export default axios
