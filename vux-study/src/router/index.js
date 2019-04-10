import Vue from 'vue'
import Router from 'vue-router'
// import HelloWorld from '@/components/HelloWorld'

Vue.use(Router)

export default new Router({
  routes: [{
    path: '/',
    redirect: 'aliveComponent'
  }, {
    path: '/aliveComponent',
    name: 'aliveComponent',
    component: resolve => require(['@/views/aliveComponent'], resolve)
  }]
})
