import http from '@/api/axiosAdvanced'
/**
 * 获取服务器地址
 */
let getIframeUrl = () => {
  return http.post(`/Public/Public/GetAddress`)
}
export {
  getIframeUrl
}
