<template>
  <div class="hello">
    <h1>{{ gettersMsg }}</h1>
  </div>
</template>

<script>
import {mapGetters} from 'vuex'
// 引入mapGetters

export default {
  name: 'hello',
  computed: {...mapGetters(['gettersMsg'])}
  // 使用mapGetters 辅助函数
}

</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
  h1, h2 {
    font-weight: normal;
  }

  ul {
    list-style-type: none;
    padding: 0;
  }

  li {
    display: inline-block;
    margin: 0 10px;
  }

  a {
    color: #42b983;
  }
</style>
