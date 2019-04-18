<template>
  <div class="Header">
    <el-button size="small" @click="getFormData" type="success">保存</el-button>
  </div>
</template>

<script>
export default {
  name: '',
  components: {},
  props: {},
  data () {
    return {
    }
  },
  computed: {},
  created () {},
  mounted () {},
  methods: {
    getFormData () {
      var data = this.$store.getters.getFormData
      this.$message({
        type: 'success',
        message: JSON.stringify(data)
      })
    }
  },
  watch: {}
}
</script>

<style scoped>
.Header{
    width: 100%;
    height: 30px;
    display: flex;
    padding: 5px 0 5px 20px;
    /* background:#B0E2FF; */
     background: linear-gradient(#b0e2ff, #5dbbf1); /* 标准的语法 */
}
</style>
