<template>
  <div class="wrap">
    <div class="main-left">
      <div class="main-tool">
        <el-button type="primary"
                   size="mini">保存</el-button>
        <el-button size="mini">盖章</el-button>
        <el-button size="mini">打印</el-button>
        <el-button size="mini">归档</el-button>
      </div>
      <div class="main-centent">
        <el-tabs v-model="activeName"
                 @tab-click="handleClick">
          <el-tab-pane label="单据"
                       name="danju">单据</el-tab-pane>
          <el-tab-pane label="流程图"
                       name="liuchengtu">
            <work-flow-chart :taskID="taskId"></work-flow-chart>
          </el-tab-pane>
          <el-tab-pane label="处理记录"
                       name="chulijilu">
            <workflow-steps :flowId="flowId"></workflow-steps>
          </el-tab-pane>
        </el-tabs>
      </div>
    </div>
    <div class="main-right"></div>
  </div>
</template>

<script type="text/ecmascript-6">
import workFlowChart from '@/components/WorkflowChart' // 流程图
import workflowSteps from '@/components/WorkflowSteps' // 处理记录
export default {
  name: 'detail',
  components: {
    workFlowChart,
    workflowSteps
  },
  created () {
    this.flowId = Number(this.$route.query.id)
    this.taskId = this.$route.query.taskId
  },
  data () {
    return {
      activeName: 'danju' // 默认显示单据
    }
  },
  methods: {
    /** tabs 点击事件 */
    handleClick (tab, event) {
      console.log(tab, event)
    }
  }
}
</script>

<style scoped lang="css">
.wrap {
  height: 100vh;
  display: flex;
  overflow: hidden;
}
.main-left {
  flex: 1;
  border: 1px solid #e0e1e5;
  flex-direction: column;
}
.main-tool {
  height: 50px;
  line-height: 50px;
  margin-left: 10px;
}
.main-centent {
  flex: 1;
}
.main-right {
  width: 310px;
}
</style>
