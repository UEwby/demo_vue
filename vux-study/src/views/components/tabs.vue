<template>
  <div class="tabs">
    <ul>
      <li v-for="item in items" :key="item"></li>
    </ul>
  </div>
</template>
<script>
export default {
  name: 'tabs',
  props: {
    items: {
      type: Array
    }
  },
  data () {
    return {
      aaa: ''
    }
  }
}
</script>
<style scoped>
  .tabs {

  }
</style>
