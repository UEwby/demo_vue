<template>
  <div>
  </div>
</template>
<script>
import { Item1, Item2 } from './components'
export default {
  name: 'aliveComponent',
  components: { Item1, Item2 },
  data () {
    return {
      currTabItem: 'Item1'
    };
  },
  methods: {
    a () {}
  }
};
</script>
