<template>
  <div class="page">
    <iframe :src="questUrl"
            frameborder=0
            scrolling=yes
            width="100%"
            height="100%"></iframe>
  </div>
</template>

<script type="text/ecmascript-6">
import { getIframeUrl } from '@/services/Public.api'
export default {
  name: 'WorkflowChart',
  data () {
    return {
      postAddress: '',
      questUrl: '/WorkflowDesigner/DesignerViewJs.aspx?taskID='
    }
  },
  components: {
  },
  props: {
    taskID: {
      type: String,
      default: function () {
        return ''
      }
    }
  },
  created () {
    this.questUrl = this.questUrl + this.taskID
  },
  mounted () {
    this.getAddress()
  },
  methods: {
    getAddress () {
      getIframeUrl().then(res => {
        this.questUrl = res.data + this.questUrl
      }).catch(res => { })
    }
  }
}
</script>

<style scoped lang="css">
.page {
  width: 100%;
  height: 0px;
  min-height: 100vh;
  max-height: 100vh;
}
</style>
