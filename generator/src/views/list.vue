<template>
  <div class="test">
    <div style="margin-bottom: 15px;">
      <Button type="primary" style="margin-right: 10px;">
        <Icon type="ios-create-outline" />
        新建
      </Button>
      <Button type="primary" ghost style="margin-right: 10px;">
        <Icon type="md-checkmark" />
        提交
      </Button>
      <Button type="primary" ghost style="margin-right: 10px;">
        <Icon type="ios-trash-outline" />
        删除
      </Button>
      <Button type="primary" ghost style="margin-right: 10px;">
        <Icon type="ios-log-out" />
        导出当前
      </Button>
      <Button type="primary" ghost style="margin-right: 10px;">
        <Icon type="ios-log-out" />
        导出全部
      </Button>
      <Button type="primary" ghost style="margin-right: 10px;">
        <Icon type="ios-log-out" />
        导出所选任务
      </Button>
    </div>
    <Page :total="40" size="small" show-elevator show-sizer class="page-top"/>
    <Table :tooltip="true" :ellipsis="true" width="100%" :columns="columns1" :data="data1" min-height="440" border ref="selection"></Table>
    <Page :total="40" size="small" show-elevator show-sizer class="page-bottom"/>
  </div>
</template>

<script>
export default {
  name: 'list',
  data () {
    return {
      columns1: [
        {
          type: 'selection',
          width: 45,
          align: 'center'
        },
        {
          title: '申请人',
          width: 80,
          key: 'name'
        },
        {
          title: '所属部门',
          width: 100,
          key: 'age'
        },
        {
          title: '申请日期',
          width: 160,
          key: 'address'
        },
        {
          title: '合计',
          width: 120,
          key: 'hj'
        },
        {
          title: '事由',
          key: 'sy',
          render: (h, params) => {
            return h('div', [
              h('span', {
                style: {
                  display: 'inline-block',
                  width: '100%',
                  overflow: 'hidden',
                  textOverflow: 'ellipsis',
                  whiteSpace: 'nowrap'
                },
                domProps: {
                  title: params.row.sy
                }
              }, params.row.sy)
            ])
          }
        }
      ],
      data1: [
        {
          name: '王永泉',
          age: '行政部',
          address: '2019-01-01 12:22:25',
          hj: '10,234,20',
          sy: '致新员工：需采购设备，但由于目前库房设备不足，故致新员工：需采购设备，但由于目前库房设备不足，故致新员工：需采购设备，但由于目前库房设备不足，故致新员工：需采购设备，但由于目前库房设备不足，故'
        },
        {
          name: '林敬波',
          age: '国际事业部',
          address: '2019-01-01 12:22:25',
          hj: '3,234,20',
          sy: '病假'
        },
        {
          name: '李国兴',
          age: '财务部',
          address: '2016-01-01 12:22:25',
          hj: '1,234,20',
          sy: '事假'
        },
        {
          name: '林敬波',
          age: '产品重心',
          address: '2019-01-01 12:22:25',
          hj: '234,20',
          sy: '年假'
        },
        {
          name: '王永泉',
          age: '项目二部',
          address: '2019-01-01 12:22:25',
          hj: '234,20',
          sy: '病假'
        },
        {
          name: '林敬波',
          age: '国际事业部',
          address: '2019-01-01 12:22:25',
          hj: '10,234,20',
          sy: '致新员工：需采购设备，但由于目前库房设备不足，'
        },
        {
          name: '王永泉',
          age: '行政部',
          address: '2019-01-01 12:22:25',
          hj: '10,234,20',
          sy: '致新员工：需采购设备，但由于目前库房设备不足，'
        },
        {
          name: '王永泉',
          age: '行政部',
          address: '2019-01-01 12:22:25',
          hj: '10,234,20',
          sy: '致新员工：需采购设备，但由于目前库房设备不足，'
        },
        {
          name: '王永泉',
          age: '行政部',
          address: '2019-01-01 12:22:25',
          hj: '10,234,20',
          sy: '致新员工：需采购设备，但由于目前库房设备不足，'
        },
        {
          name: '王永泉',
          age: '行政部',
          address: '2019-01-01 12:22:25',
          hj: '10,234,20',
          sy: '致新员工：需采购设备，但由于目前库房设备不足，'
        },
        {
          name: '王永泉',
          age: '行政部',
          address: '2019-01-01 12:22:25',
          hj: '10,234,20',
          sy: '致新员工：需采购设备，但由于目前库房设备不足，'
        },
        {
          name: '王永泉',
          age: '行政部',
          address: '2019-01-01 12:22:25',
          hj: '10,234,20',
          sy: '致新员工：需采购设备，但由于目前库房设备不足，'
        },
        {
          name: '王永泉',
          age: '行政部',
          address: '2019-01-01 12:22:25',
          hj: '10,234,20',
          sy: '致新员工：需采购设备，但由于目前库房设备不足，'
        },
        {
          name: '王永泉',
          age: '行政部',
          address: '2019-01-01 12:22:25',
          hj: '10,234,20',
          sy: '致新员工：需采购设备，但由于目前库房设备不足，'
        },
        {
          name: '王永泉',
          age: '行政部',
          address: '2019-01-01 12:22:25',
          hj: '10,234,20',
          sy: '致新员工：需采购设备，但由于目前库房设备不足，'
        },
        {
          name: '王永泉',
          age: '行政部',
          address: '2019-01-01 12:22:25',
          hj: '10,234,20',
          sy: '致新员工：需采购设备，但由于目前库房设备不足，'
        },
        {
          name: '王永泉',
          age: '行政部',
          address: '2019-01-01 12:22:25',
          hj: '10,234,20',
          sy: '致新员工：需采购设备，但由于目前库房设备不足，'
        },
        {
          name: '王永泉',
          age: '行政部',
          address: '2019-01-01 12:22:25',
          hj: '10,234,20',
          sy: '致新员工：需采购设备，但由于目前库房设备不足，'
        },
        {
          name: '王永泉',
          age: '行政部',
          address: '2019-01-01 12:22:25',
          hj: '10,234,20',
          sy: '致新员工：需采购设备，但由于目前库房设备不足，'
        },
        {
          name: '王永泉',
          age: '行政部',
          address: '2019-01-01 12:22:25',
          hj: '10,234,20',
          sy: '致新员工：需采购设备，但由于目前库房设备不足，'
        }
      ]
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.test {

}
</style>
<style>
  .page-bottom,
  .page-top {
    padding: 8px 0;
    text-align: right;
    border: 1px solid #dcdee2;
    padding-right: 15px;
  }
  .page-top {
    border-bottom: none;
  }
  .page-bottom {
    border-top: none;
  }
  .ivu-icon {
    font-size: 17px;
  }
  .ivu-icon-ios-log-out{
    transform: rotate(270deg);
  }
  .ivu-table-wrapper {
    max-height: calc(100vh - 222px) !important;
  }
  .ivu-table-header thead tr th:nth-child(6){
    border-right: none;
  }
  .ivu-table-body tbody tr td:nth-child(6){
    border-right: none;
  }
</style>
