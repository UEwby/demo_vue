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
    <Table :columns="columns1" :data="data1" height="440" border ref="selection"></Table>
    <Page :total="40" size="small" show-elevator show-sizer class="page-bottom"/>
  </div>
</template>

<script>
export default {
  name: 'HelloWorld',
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
          key: 'sy'
        }
      ],
      data1: [
        {
          name: '王永泉',
          age: '行政部',
          address: '2019-01-01 12:22:25',
          hj: '10,234,20',
          sy: '致新员工：需采购设备，但由于目前库房设备不足，故...'
        },
        {
          name: '王永泉',
          age: '行政部',
          address: '2019-01-01 12:22:25',
          hj: '10,234,20',
          sy: '致新员工：需采购设备，但由于目前库房设备不足，故...'
        },
        {
          name: '王永泉',
          age: '行政部',
          address: '2019-01-01 12:22:25',
          hj: '10,234,20',
          sy: '致新员工：需采购设备，但由于目前库房设备不足，故...'
        },
        {
          name: '王永泉',
          age: '行政部',
          address: '2019-01-01 12:22:25',
          hj: '10,234,20',
          sy: '致新员工：需采购设备，但由于目前库房设备不足，故...'
        },
        {
          name: '王永泉',
          age: '行政部',
          address: '2019-01-01 12:22:25',
          hj: '10,234,20',
          sy: '致新员工：需采购设备，但由于目前库房设备不足，故...'
        },
        {
          name: '王永泉',
          age: '行政部',
          address: '2019-01-01 12:22:25',
          hj: '10,234,20',
          sy: '致新员工：需采购设备，但由于目前库房设备不足，故...'
        },
        {
          name: '王永泉',
          age: '行政部',
          address: '2019-01-01 12:22:25',
          hj: '10,234,20',
          sy: '致新员工：需采购设备，但由于目前库房设备不足，故...'
        },
        {
          name: '王永泉',
          age: '行政部',
          address: '2019-01-01 12:22:25',
          hj: '10,234,20',
          sy: '致新员工：需采购设备，但由于目前库房设备不足，故...'
        },
        {
          name: '王永泉',
          age: '行政部',
          address: '2019-01-01 12:22:25',
          hj: '10,234,20',
          sy: '致新员工：需采购设备，但由于目前库房设备不足，故...'
        },
        {
          name: '王永泉',
          age: '行政部',
          address: '2019-01-01 12:22:25',
          hj: '10,234,20',
          sy: '致新员工：需采购设备，但由于目前库房设备不足，故...'
        },
        {
          name: '王永泉',
          age: '行政部',
          address: '2019-01-01 12:22:25',
          hj: '10,234,20',
          sy: '致新员工：需采购设备，但由于目前库房设备不足，故...'
        },
        {
          name: '王永泉',
          age: '行政部',
          address: '2019-01-01 12:22:25',
          hj: '10,234,20',
          sy: '致新员工：需采购设备，但由于目前库房设备不足，故...'
        },
        {
          name: '王永泉',
          age: '行政部',
          address: '2019-01-01 12:22:25',
          hj: '10,234,20',
          sy: '致新员工：需采购设备，但由于目前库房设备不足，故...'
        },
        {
          name: '王永泉',
          age: '行政部',
          address: '2019-01-01 12:22:25',
          hj: '10,234,20',
          sy: '致新员工：需采购设备，但由于目前库房设备不足，故...'
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
    border: 1px solid #e8eaec;
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
</style>
