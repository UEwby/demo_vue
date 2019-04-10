<template>
  <div class="box-card">
    <h4 class="card-title">
      <span v-text="title"></span>
      <a target="_blank" style="cursor:pointer" @click="openPanel('RWZX',openUrl,'信息发布',true)">更多</a>
    </h4>
    <ul class="card-body">
      <li v-for="item in content" :key="item.id" @click="clickTitle(item)" style="cursor:pointer">
        <div>
          <a @click="openPanel(codeFL,'/GB/LK/IRS/InfoView/InfoView.aspx?infoID='+item.id+'&listtype=1&pageCode='+codeFL+'&pageindex=1','政策法规',true)" class="title">{{item.title}}</a>
        </div><span class="date">{{item.createTime}}</span>
      </li>
    </ul>
  </div>
</template>

<script>
export default {
  name: 'KP',
  props: {
    list: {
      type: Array
    },
    title: {
      type: String,
      default: '标题'
    },
    href: {
      type: String,
      default: '/homepage'
    },
    codeFL: {
      type: String,
      default: function () {
        return ''
      }
    },
    openUrl: {
      type: String,
      default: function () {
        return ''
      }
    }
  },
  data () {
    return {
      content: []
    }
  },
  mounted () {
    this.loadContent()
  },
  methods: {
    loadContent: function () {
      let self = this
      self.$http({
        type: 'post',
        url: '/action.ashx',
        params: {
          controller: 'GTP.PortalDataService.WorkFlow.TaskController',
          action: 'GetXXFB',
          args: "['" + self.codeFL + "']"
        }
      }).then(function (response) {
        self.content = response.data.Data
      }).catch(function (error) {
        console.log(error)
      })
    }
  },
  watch: {
    codeFL (value, oldvalue) {
      console.log(self.codeFL)
      this.loadContent()
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped lang="Less">
  .box-card{
    height: 300px;
    overflow: hidden;
    border: 1px solid #EBEBEB;
    border-radius: 5px;
    font-size: 14px;
    padding: 22px 22px 0;
    .card-title{
      display: flex;
      justify-content: space-between;
      border-bottom: 1px solid #CDCDCD;
      margin: 0 2px;
      span{
        font-size: 16px;
        color: #2373C8;
        border-bottom: 2px solid ;
        /*line-height: 21px;*/
        padding: 0 3px 3px;
        margin-bottom: -1px;
      }
      a{
        color: #BFBFBF;
        font-size: 12px;
        line-height: 28px;
      }
    }
    .card-body{
      .date{
        color: #A4A4A4;
        flex-basis: 80px;
        width: 80px;
      }
      li{
        display: flex;
        height: 19px;
        margin: 19px 0;
        color: #595959;
        justify-content: space-between;
        div{
          display: block;
          overflow: hidden;
          text-overflow: ellipsis;
          white-space: nowrap;
          flex: 1 1 0%;
        }
        .title{
          position: relative;
          display: block;
          padding-left: 15px;
          overflow: hidden;
          text-overflow:ellipsis;
          white-space: nowrap;
          min-width: 0px;
          flex:1;
          &:before {
            position: absolute;
            top: 8px;
            left: 0;
            width: 4px;
            height: 3px;
            background-color: #595959;
            content: '';
            display: block;
          }
        }
      }

    }
  }
</style>
