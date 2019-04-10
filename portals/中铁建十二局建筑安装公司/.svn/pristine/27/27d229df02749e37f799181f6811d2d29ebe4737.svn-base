exports.install = function (Vue, options) {
  Vue.prototype.openPanel = function (id, url, title, innerPanel) {
    debugger
    if (!url) {
      return
    }
    if (innerPanel && window.parent && window.parent.Portal && window.parent.Portal.Tab) {
      window.parent.Portal.Tab.Show({id: 'Portal' + id, title: title, url: url})
    } else if (innerPanel && window.parent && window.parent.openPanel) {
      window.parent.openPanel(id, '', title, url)
    } else {
      window.open(url, title)
    }
  }
}
