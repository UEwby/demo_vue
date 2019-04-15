<template>
  <div id="app">
    <h4 class="title"></h4>
    <div class="content">
      <Menu :theme="'light'" class="content-left">
        <MenuItem name="1">文章管理</MenuItem>
        <MenuItem name="2">文章管理</MenuItem>
        <MenuItem name="3">文章管理</MenuItem>
        <MenuItem name="4">文章管理</MenuItem>
        <MenuItem name="5">文章管理</MenuItem>
        <MenuItem name="6">文章管理</MenuItem>
        <MenuItem name="7">文章管理</MenuItem>
        <MenuItem name="8">文章管理</MenuItem>
      </Menu>
      <router-view class="content-right"/>
    </div>
  </div>
</template>

<script>
export default {
  name: 'App'
}
</script>

<style>
#app {
}
  .title {
    height: 50px;
    background: #3B8DEE url("assets/logo.jpg") no-repeat 0 0;
  }
  .content {
    display: flex;
    justify-content: flex-start;
  }
  .content-left {
    width: 230px;
    height: calc(100vh - 50px);
  }
  .content-right {
    padding: 20px;
    flex: 1;
  }
</style>
