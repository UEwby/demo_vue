import http from './axiosAdvanced'

export default {
  install: function (Vue, Option) {
    Object.defineProperty(Vue.prototype, '$http', {
      value: http
    })
  }
}
