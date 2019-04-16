import http from '../api/axiosAdvanced'
// 同意-获取任务所属流程流转上下文信息
let smartAdvanceQueryAsync = (taskId, remark, result) => {
  return http.post(
    `/gongwenfawen/FaWenLieBiao/SmartAdvanceQueryAsync?taskId=${taskId}&result=${encodeURI(result)}`,
    { remark: remark }
  )
}

export {
  smartAdvanceQueryAsync
}
