<template>
      <span :class="{'allowBlank': allowBlank, 'notAllowBlank': !allowBlank ,'readOnly': readOnly}" class="underline">{{value}}</span>
</template>

<script>
export default {
  name: 'underline',
  components: {},
  props: {
    value: {
      type: String,
      default: ''
    },
    allowBlank: {
      type: Boolean,
      default: false
    },
    readOnly: {
      type: Boolean,
      default: true
    }
  },
  data () {
    return {
    }
  },
  computed: {},
  created () {},
  mounted () {
  },
  methods: {},
  watch: {}
}
</script>

<style scoped>
.underline{
    width: 95%;
    margin-bottom: 8px;
    display: block;
    /* text-align: left; */
}
.allowBlank{
    border-bottom: 1px solid rgb(74, 149, 239);
}
.notAllowBlank{
     border-bottom: 1px solid red;
}
.readOnly{
    border-bottom:0;
}
</style>
