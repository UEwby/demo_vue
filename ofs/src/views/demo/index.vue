<template>
  <div>
      <Header></Header>
      <div :style="'width:'+width+';margin:0 auto;'">
      <Display :code="html"></Display>
      </div>
  </div>
</template>

<script>
import Header from './components/Header'
import Display from '@/components/Display/LODisplay'
export default {
  name: '',
  components: {
    Header,
    Display
  },
  props: {},
  data () {
    return {
      html: '',
      setting: '',
      width: '50%',
      formTemplateId: 100601
    }
  },
  computed: {},
  created () {
    this.getFormVueTemplateSetting()
  },
  mounted () {},
  methods: {
    initFormData () {
      this.$store.commit('setFormSetting', this.setting)

      for (let element of this.setting) {
        // 有集合项说明为细表字段
        if (element.items) {
          this.$store.state.formData[element.id] = [{rowIndex: 1}]
        }
      }
    },
    getFormVueTemplateSetting () {
      let postData = {
        controller: 'GTP.Forms.Builder.OnlineFormsBuilder',
        action: 'GetFormVueTemplateSetting',
        args: [this.formTemplateId]
      }
      this.$http.post('/common/action.ashx', postData).then((response) => {
        // 加载配置项
        this.setting = JSON.parse(response.Data.setting)
        // 页面宽度
        if (response.Data.width > 0) {
          this.width = response.Data.width + 'px'
        }

        // 加载配置项
        this.initFormData()
        // 获取模板
        this.getFormVueTemplate()
      })
    },
    getFormVueTemplate () {
      let postData = {
        controller: 'GTP.Forms.Builder.OnlineFormsBuilder',
        action: 'GetFormVueTemplate',
        args: [this.formTemplateId]
      }
      this.$http.post('/common/action.ashx', postData).then((response) => {
        this.html = response.Data
      })
    }
  },
  watch: {}
}
</script>

<style scoped>
</style>
