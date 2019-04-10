import axios from 'axios'

const Axios = axios.create({
  baseURL: '/api', // 因为我本地做了反向代理
  headers: {
    'Content-Type': 'application/json;charset=utf-8'
  }
})

Axios.interceptors.response.use(function (response) {
  // 返回响应时做一些处理
  if (response.request.responseURL && response.request.responseURL.indexOf('Services/Identification/Server/login.ashx') > 0) {
    window.location = '/Services/Identification/Server/Login.aspx'
    return response
  } else {
    return response
  }
}, function (error) {
  // 当响应异常时做一些处理
  return Promise.reject(error)
})

// 对axios的实例重新封装成一个plugin ,方便 Vue.use(xxxx)
export default {
  install: function (Vue, Option) {
    Object.defineProperty(Vue.prototype, '$http', {
      value: Axios
    })
  }
}
