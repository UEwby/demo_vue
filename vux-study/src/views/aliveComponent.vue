<template>
  <div>
    <el-tabs type="border-card">
      <el-tab-pane label="项目一"></el-tab-pane>
      <el-tab-pane label="项目二">项目二</el-tab-pane>
    </el-tabs>
  </div>
</template>
<script>
import { Item1, Item2 } from './components'
export default {
  name: 'aliveComponent',
  components: { Item1, Item2 },
  data () {
    return {
      aaa: ''
    };
  },
  methods: {
    a () {}
  }
};
</script>
