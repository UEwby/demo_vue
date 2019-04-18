// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import App from './App'
import router from './router'
import store from './store'
import ElementUI from 'element-ui'
import VueCookies from 'vue-cookies'
// import 'element-ui/lib/theme-chalk/index.css'
import '../theme/index.css'
// import 'gtpvuefe/style/main.css'
import './assets/iconfont/iconfont.css'
import axiosPlugin from './api'
import utils from './assets/utils'
import 'babel-polyfill'
import infiniteScroll from 'vue-infinite-scroll'
import InputCom from '../src/components/Input/LOInput'
import DateCom from '../src/components/Date/LODate'
import LookupCom from '../src/components/Org/LOLookup'
import '../src/assets/base.css'

const COM = {
  install: function (Vue) {
    Vue.component('input-com', InputCom)
    Vue.component('date-com', DateCom)
    Vue.component('lookup-com', LookupCom)
  }
}

Vue.use(COM)

Vue.use(infiniteScroll)

Vue.config.productionTip = false

Vue.use(axiosPlugin)

Vue.use(ElementUI)

Vue.use(VueCookies)

Vue.use(utils)

/* eslint-disable no-new */
new Vue({
  el: '#app',
  router,
  store,
  components: {
    App
  },
  template: '<App/>'
})
