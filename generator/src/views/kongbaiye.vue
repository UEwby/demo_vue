<template>
    <div>{{text}}</div>
</template>

<script>
export default {
  name: 'kongbaiye',
  data () {
    return {
      text: ''
    }
  },
  mounted () {
    let path = this.$route.fullPath
    console.log(path)
    switch (path) {
      case '/index/kongbaiye2':
        this.text = '流程地图'
        break
      case '/index/kongbaiye3':
        this.text = '财务流程'
        break
      case '/index/kongbaiye4':
        this.text = '公文管理'
        break
      case '/index/kongbaiye5':
        this.text = '任务督办'
        break
      case '/index/kongbaiye6':
        this.text = '信息发布'
        break
      case '/index/kongbaiye7':
        this.text = '文档资料'
        break
      case '/index/kongbaiye8':
        this.text = '新物品管理'
        break
      case '/index/kongbaiye9':
        this.text = '工作总结'
        break
      case '/index/kongbaiye10':
        this.text = '物品管理'
        break
      case '/index/kongbaiye11':
        this.text = '考勤管理'
        break
      case '/index/kongbaiye12':
        this.text = '人员管理'
        break
      case '/index/kongbaiye13':
        this.text = '数据维护'
        break
      case '/index/kongbaiye14':
        this.text = '会议管理'
        break
      default:
        break
    }
  }
}
</script>

<style scoped>

</style>
