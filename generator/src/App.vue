<template>
  <div id="app">
    <router-view/>
  </div>
</template>

<script>
export default {
  name: 'App'
}
</script>

<style>
  html,
  body {
    font-family: "Microsoft YaHei","微软雅黑","Helvetica Neue",Helvetica,"PingFang SC","Hiragino Sans GB",Arial,sans-serif;
  }
#app {
}
  /* 自定义 chrome 的滚动条样式*/
  /*==== 全局定义 ====*/
  ::-webkit-scrollbar {
    width: 7px;
    height: 7px;
  }
  ::-webkit-scrollbar-thumb {
    background: #E2E3E8;
    border-radius: 5px;
    cursor: pointer;
  }
</style>
