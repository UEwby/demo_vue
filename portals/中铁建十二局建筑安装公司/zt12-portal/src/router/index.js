import Vue from 'vue'
import Router from 'vue-router'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      redirect: '/homepage'
    },
    {
      path: '/homepage',
      name: 'Homepage',
      component: resolve => require(['@/views/Homepage'], resolve)
    },
    {
      path: '/links',
      name: 'Links',
      component: resolve => require(['@/views/Links'], resolve)
    }
  ]
})
