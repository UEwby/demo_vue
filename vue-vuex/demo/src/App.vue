<template>
  <div id="app">
    <router-link to="/">点击进入hello首页</router-link>
    <br>
    <router-link to="/hello1">点击进入hello1</router-link>
    <br>
    <router-view/>
    <p>我是App.vue中的p， gettersMsg 的值是----- {{gettersMsg}}</p>
  </div>
</template>

<script>
export default {
  name: 'App'
}
</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  padding: 20px;
}
</style>
