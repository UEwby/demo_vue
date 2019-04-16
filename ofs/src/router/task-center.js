export default [
  {
    path: '/taskCenter',
    name: 'taskCenter',
    tagName: '发文列表首页',
    component: (resolve) => require(['@/views/task-center'], resolve),
    children: [
      {
        path: '/',
        redirect: '/taskCenter/daiBanList'
      },
      {
        path: '/taskCenter/daiBanList',
        name: 'daiBanList',
        tagName: '待办列表',
        component: (resolve) => require(['@/views/task-center/components/DaiBanList'], resolve)
      },
      {
        path: '/taskCenter/yiBanList',
        name: 'yiBanList',
        tagName: '已办列表',
        component: (resolve) => require(['@/views/task-center/components/YiBanList'], resolve)
      },
      {
        path: '/taskCenter/daiYueList',
        name: 'daiYueList',
        tagName: '待阅列表',
        component: (resolve) => require(['@/views/task-center/components/DaiYueList'], resolve)
      },
      {
        path: '/taskCenter/yiYueList',
        name: 'yiYueList',
        tagName: '已阅列表',
        component: (resolve) => require(['@/views/task-center/components/YiYueList'], resolve)
      },
      {
        path: '/taskCenter/caoGaoList',
        name: 'caoGaoList',
        tagName: '草稿列表',
        component: (resolve) => require(['@/views/task-center/components/CaoGaoList'], resolve)
      }
    ]
  }
]
