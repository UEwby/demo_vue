<template>
  <div @click="edit" class="lo-box" v-show="!setting.hidden">
      <Underline v-show="!isEdit"
                 v-model="conValue"
                 :allowBlank="setting.allowBlank"
                  :readOnly="setting.readOnly"
      ></Underline>
      <el-input @blur="check" ref="LOInput" v-show="isEdit" v-model="conValue" placeholder="请输入"></el-input>
  </div>
</template>

<script>
import Underline from '@/components/Line/LOLine'
import store from '@/store'
export default {
  name: 'LOInput',
  inject: ['app'],
  components: {
    Underline
  },
  props: {
    name: {
      type: String,
      default: ''
    },
    // 所属细表
    belong: {
      type: String,
      default: ''
    }
  },
  data () {
    return {
      isEdit: false,
      conValue: '',
      setting: {}
    }
  },
  computed: {},
  created () {},
  mounted () {
    this.setting = store.getters.getSettingByName({name: this.name, belong: this.belong})
    // 默认值
    this.conValue = this.setting.defaultValueExpression || ''
    // console.log(this.setting)
  },
  methods: {
    edit () {
      // 只读不可编辑
      if (!this.setting.readOnly) {
        this.isEdit = true
      }
    },
    check () {
      this.isEdit = false
    }
  },
  watch: {
    isEdit (val) {
      this.$nextTick(() => {
        this.$refs.LOInput.focus()
      })
    },
    conValue (val) {
      store.commit('setFormDataByName', {name: this.name, value: val, belong: this.belong})
    }
  }
}
</script>

<style scoped>
.lo-box{
    height: 100%;
    width: 100%;
    display: flex;
    flex-direction: column ;
    justify-content: flex-end;
    align-items: center;
}
</style>
