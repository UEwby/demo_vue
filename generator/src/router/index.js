import Vue from 'vue'
import Router from 'vue-router'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      redirect: '/index'
    }, {
      path: '/index',
      name: 'index',
      component: (resolve) => require(['@/views/index'], resolve),
      children: [
        {
          path: '/',
          redirect: '/index/list'
        },
        {
          path: '/index/list',
          name: 'list',
          component: (resolve) => require(['@/views/list'], resolve)
        },
        {
          path: '/index/formData',
          name: 'formData',
          component: (resolve) => require(['@/views/formData'], resolve)
        },
        {
          path: '/index/kongbaiye2',
          name: 'kongbaiye2',
          component: (resolve) => require(['@/views/kongbaiye'], resolve)
        },
        {
          path: '/index/kongbaiye3',
          name: 'kongbaiye3',
          component: (resolve) => require(['@/views/kongbaiye'], resolve)
        },
        {
          path: '/index/kongbaiye4',
          name: 'kongbaiye',
          component: (resolve) => require(['@/views/kongbaiye'], resolve)
        },
        {
          path: '/index/kongbaiye5',
          name: 'kongbaiye5',
          component: (resolve) => require(['@/views/kongbaiye'], resolve)
        },
        {
          path: '/index/kongbaiye6',
          name: 'kongbaiye6',
          component: (resolve) => require(['@/views/kongbaiye'], resolve)
        },
        {
          path: '/index/kongbaiye7',
          name: 'kongbaiye7',
          component: (resolve) => require(['@/views/kongbaiye'], resolve)
        },
        {
          path: '/index/kongbaiye8',
          name: 'kongbaiye8',
          component: (resolve) => require(['@/views/kongbaiye'], resolve)
        },
        {
          path: '/index/kongbaiye9',
          name: 'kongbaiye9',
          component: (resolve) => require(['@/views/kongbaiye'], resolve)
        },
        {
          path: '/index/kongbaiye10',
          name: 'kongbaiye10',
          component: (resolve) => require(['@/views/kongbaiye'], resolve)
        },
        {
          path: '/index/kongbaiye11',
          name: 'kongbaiye11',
          component: (resolve) => require(['@/views/kongbaiye'], resolve)
        },
        {
          path: '/index/kongbaiye12',
          name: 'kongbaiye12',
          component: (resolve) => require(['@/views/kongbaiye'], resolve)
        },
        {
          path: '/index/kongbaiye13',
          name: 'kongbaiye13',
          component: (resolve) => require(['@/views/kongbaiye'], resolve)
        },
        {
          path: '/index/kongbaiye14',
          name: 'kongbaiye14',
          component: (resolve) => require(['@/views/kongbaiye'], resolve)
        }
      ]
    }
  ]
})
