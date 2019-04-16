/**
  *  url 需要打开的地址
  * * title 显示的标题
  **  taskId 公文id
  * * id id
  */

const openPageChange = (path, taskId, id, title) => {
  var url = '#' + path + '?id=' + id + '&taskId=' + taskId
  window.open(url, '_blank')
}
const openPageChangeDaiBanXQ = (path, taskId, id, title, isYiJian, isSendBoxAgree, isSendBoxDisagree) => {
  var url = '#' + path + '?id=' + id + '&taskId=' + taskId + '&isYiJian=' + isYiJian + '&isSendBoxAgree=' + isSendBoxAgree + '&isSendBoxDisagree=' + isSendBoxDisagree
  window.open(url, '_blank')
}

/**
 * 使用es6的export default导出了一个函数，心跳触发刷新事件，
 * 函数的参数及返回值如下：
 * @param {String} type  监听标识(需自定义)
 * @param {Object} even     需要出发的事件
 * @param {Boolean} async    需要即可触发事件填写true （其他勿填）
 */
const watchHeartbeat = (type, even, async) => {
  setTimeout(() => {
    if (async) {
      if (localStorage.getItem(type) === 'true') {
        watchHeartbeat(type, even, true)
      } else if (localStorage.getItem(type) === 'destroy') {
        even.call()
      } else {
        localStorage.setItem(type, 'true')
        even.call()
        watchHeartbeat(type, even, true)
      }
    } else {
      localStorage.setItem(type, 'true')
      watchHeartbeat(type, even, true)
    }
  }, 500)
}

/**
 * 心跳触发刷新事件，
 * 函数的参数及返回值如下：
 * @param {String} type  监听标识(需自定义)
 * @param {Boolean} destroy  触发后销毁
 */
const beckoning = (type, destroy) => {
  if (destroy) {
    localStorage.setItem(type, 'destroy')
  } else {
    localStorage.setItem(type, 'false')
  }
}

let common = {}

common.install = function (Vue, options) {
  Vue.prototype.$openPage = openPageChange
  Vue.prototype.$openPage2 = openPageChangeDaiBanXQ
  Vue.prototype.$watchHeartbeat = watchHeartbeat
  Vue.prototype.$beckoning = beckoning
}

export default common
