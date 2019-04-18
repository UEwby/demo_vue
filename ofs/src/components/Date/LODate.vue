<template>
  <div @click="edit" class="lo-box" v-show="!setting.hidden">
      <Underline v-show="!isEdit"
                 v-model="conValue"
                 :allowBlank="setting.allowBlank"
                 :readOnly="setting.readOnly">></Underline>
    <el-date-picker
        style="width:100%;"
         v-show="isEdit" @blur="check" v-model="conValue" ref="LODate" align="right" type="date"
         format="yyyy 年 MM 月 dd 日"
         value-format="yyyy-MM-dd"
         placeholder="选择日期">
    </el-date-picker>
  </div>
</template>

<script>
import Underline from '@/components/Line/LOLine'
import store from '@/store'
export default {
  name: 'LODate',
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
        this.$refs.LODate.focus()
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
