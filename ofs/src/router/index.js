import Vue from 'vue'
import Router from 'vue-router'
import store from '../store'
import cookies from 'vue-cookies'

Vue.use(Router)

const routes = [
  {
    path: '/',
    redirect: '/demo'
  },
  {
    path: '/ledger',
    name: 'ledger',
    tagName: '台账页面',
    meta: {
      unauthorized: true
    },
    component: resolve => require(['@/views/ledger'], resolve)
  },
  {
    path: '/detail',
    name: 'detail',
    tagName: '详情',
    meta: {
      unauthorized: true
    },
    component: resolve => require(['@/views/detail'], resolve)
  },
  {
    path: '/Login',
    name: 'Login',
    tagName: '认证首页',
    meta: {
      unauthorized: true
    },
    component: resolve => require(['@/views/login/Login'], resolve)
  }, {
    path: '/demo',
    name: 'demo',
    meta: {
      unauthorized: true
    },
    component: resolve => require(['@/views/demo'], resolve)
  }
]

let otac = null

if (new RegExp('[?|&]otac=' + '([^&;]+?)(&|#|;|$)').exec(location.href)) {
  otac = decodeURIComponent(
    new RegExp('[?|&]otac=' + '([^&;]+?)(&|#|;|$)')
      .exec(location.href)[1]
      .replace(/\+/g, '%20')
  )
}

// 页面刷新时，重新赋值token
if (otac && window.localStorage.getItem(otac)) {
  store.commit('login', {
    otac: otac,
    token: window.localStorage.getItem(otac)
  })
}

const router = new Router({
  routes
})

router.beforeEach((to, from, next) => {
  if (to.matched.some(r => r.meta.unauthorized)) {
    next()
  } else {
    if (store.state.token) {
      next()
    } else {
      let cookie = cookies.get('IdentityResult')
      if (cookie) {
        const token = cookie.data.access_token
        // store.commit('login', token)
        store.commit('login', { otac: otac, token: token })
        next()
      } else {
        next({
          path: '/login',
          query: { redirect: to.path, otac: to.query.otac }
        })
      }
    }
  }
})

export default router
