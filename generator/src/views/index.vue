<template>
    <div class="index">
      <h4 class="title"></h4>
      <div class="content">
        <Menu :theme="'light'"
              class="content-left"
              @on-select="navigateTo"
              active-name="/index/list">
          <menu-item name="/index/formData">管控首页</menu-item>
          <menu-item name="/index/kongbaiye2">日常审批</menu-item>
          <menu-item name="/index/kongbaiye3">公文管理</menu-item>
          <menu-item name="/index/kongbaiye4">任务督办</menu-item>
          <menu-item name="/index/kongbaiye5">公文应用</menu-item>
          <menu-item name="/index/list">财务流程</menu-item>
          <menu-item name="/index/kongbaiye6">信息发布</menu-item>
          <menu-item name="/index/kongbaiye7">文档资料</menu-item>
          <menu-item name="/index/kongbaiye8">新物品管理</menu-item>
          <menu-item name="/index/kongbaiye9">工作总结</menu-item>
          <menu-item name="/index/kongbaiye10">物品管理</menu-item>
          <menu-item name="/index/kongbaiye11">考勤管理</menu-item>
        </Menu>
        <router-view class="content-right"/>
      </div>
    </div>
</template>

<script>
export default {
  name: 'index',
  methods: {
    navigateTo (name) {
      console.log(name)
      this.$router.push(name)
    }
  }
}
</script>

<style scoped>
  .title {
    height: 50px;
    background: #3B8DEE url("../assets/logo.jpg") no-repeat 0 0;
  }
  .content {
    display: flex;
    justify-content: flex-start;
  }
  .content-left {
    width: 230px;
    height: calc(100vh - 50px);
    overflow: auto;
  }
  .content-right {
    padding: 20px;
    flex: 1;
  }
</style>
