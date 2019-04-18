import http from '@/api/axiosAdvanced'

/**
 * 获取业务生成器审批详情 处理记录列表
 * @param {*} params 参数 {gwId:公文id,pgaeIndex:页面,pageSize：条数}
 */
let getChuLiJiLuPageList = (params) => {
  return http.post(`/XiangQing/XiangQing/GetChuLiJiLuList`, params)
}

export {
  getChuLiJiLuPageList
}
