<template>
  <div>
    <el-button size="mini" property @click="toggleShow">toggle</el-button>
    {{str}}
    <div v-if="isshowing">我是模态框</div>
  </div>
</template>
<script>
import {toggle} from './mixin'
export default {
  name: '',
  mixins: [toggle],
  data () {
    return {
      str: '11111'
    }
  },
  methods: {
    fn2 () {
      console.log('11111')
    }
  },
  created () {
    console.log('组件钩子被调用')
  },
  mounted () {
    this.fn2()
  }
}
</script>

<style>

</style>
