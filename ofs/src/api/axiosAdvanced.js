import http from './axiosInstance'

// 二次封装预留
const HTTP_ADVANCED = {
  request (config) {
    return http.request(config)
  },
  get (url, config) {
    return http.get(url, config)
  },
  delete (url, config) {
    return http.delete(url, config)
  },
  head (url, config) {
    return http.head(url, config)
  },
  options: function (url, config) {
    return http.options(url, config)
  },
  post (url, data, config) {
    return http.post(url, data, config)
  },
  put (url, data, config) {
    return http.put(url, data, config)
  },
  patch (url, data, config) {
    return http.patch(url, data, config)
  },
  getUri (config) {
    return http.getUri(config)
  }
}

// 导出默认的配置
export default HTTP_ADVANCED
