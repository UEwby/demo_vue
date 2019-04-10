// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import App from './App'
import router from './router'
import ElementUI from 'element-ui'
import 'element-ui/lib/theme-chalk/index.css'
import api from './assets/api/index'
import 'babel-polyfill'
Vue.use(ElementUI)
Vue.use(api)

Vue.config.productionTip = false
Vue.prototype.openPanel = function (id, url, title, innerPanel) {
  if (!url) {
    return
  }
  if (innerPanel && window.parent && window.parent.Portal && window.parent.Portal.Tab) {
    window.parent.Portal.Tab.Show({id: 'Portal' + id, title: title, url: url})
  } else if (innerPanel && window.parent && window.parent.openPanle) {
    window.parent.openPanle(id, '', title, url)
  } else {
    window.open(url, title, 'width=' + (window.screen.availWidth - 10) + ',height=' + (window.screen.availHeight - 40) + ', top=0, left=0, toolbar=no, menubar=no, scrollbars=no, resizable=no, location=no, status=no')
  }
}
/* eslint-disable no-new */
new Vue({
  el: '#app',
  router,
  components: { App },
  template: '<App/>'
})
