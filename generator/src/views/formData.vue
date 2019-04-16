<template>
  <div class="test">
    <div class="test-left">
      <div style="margin-bottom: 15px;">
        <Button type="primary" style="margin-right: 10px;">
          保存
        </Button>
        <Button type="primary" ghost style="margin-right: 10px;">
          盖章
        </Button>
        <Button type="primary" ghost style="margin-right: 10px;">
          打印
        </Button>
        <Button type="primary" ghost style="margin-right: 10px;">
          存档
        </Button>
      </div>
      <Tabs value="name1" style="margin-bottom: 15px; text-align: center;">
        <TabPane label="单据" name="name1" ><div v-html="htmlstr"></div></TabPane>
        <TabPane label="流程图" name="name2"><img src="../assets/workflow.png"/></TabPane>
        <TabPane label="处理记录" name="name3">处理记录</TabPane>
      </Tabs>
    </div>
    <div class="test-right">
      <Dropdown style="margin-bottom: 10px;" @on-click="setValue6">
        <Button type="primary" ghost>
          常用意见
          <Icon type="ios-arrow-down"></Icon>
        </Button>
        <DropdownMenu slot="list">
          <DropdownItem name="驴打滚">驴打滚</DropdownItem>
          <DropdownItem name="炸酱面">炸酱面</DropdownItem>
          <DropdownItem name="豆汁儿">豆汁儿</DropdownItem>
          <DropdownItem name="冰糖葫芦">冰糖葫芦</DropdownItem>
          <DropdownItem name="北京烤鸭">北京烤鸭</DropdownItem>
        </DropdownMenu>
      </Dropdown>
      <Input v-model="value6" type="textarea" :rows="8" placeholder="Enter something..." />
      <div style="margin-top: 15px;display: flex;justify-content: space-between;">
        <Button type="primary" size="large" style="width: 40%;">
          同意
        </Button>
        <Button type="primary" ghost size="large" style="width: 40%;">
          不同意
        </Button>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: 'formData',
  data () {
    return {
      htmlstr: `<div style="text-align: center; color: rgb(255, 0, 0); font-size: 24pt;">&nbsp;</div>
          <div style="text-align: center; color: rgb(255, 0, 0); font-size: 24pt;">广联达拟稿纸</div>
          <table width="630" align="center" bordercolor="#ff0000"
            style="border-style: solid; border-collapse: collapse; table-layout: fixed;" bgcolor="#ffffff" border="1"
            cellspacing="0" cellpadding="3">
            <tbody>
              <tr height="30">
                <td style="width: 110px; border: 1px solid #FF0000;text-align: center; font-family: &quot;宋体&quot;, Simsun;">
                  <font style="color: rgb(255, 0, 0); font-size: 14pt;">标&nbsp;&nbsp;&nbsp;&nbsp;题</font>
                </td>
                <td style="text-align: center; border: 1px solid #FF0000; vertical-align: middle; -ms-word-break: break-all;"
                  colspan="3"><span id="tmplt_1337585953850F_TITLE" _fieldname="F_TITLE" _isfield="true"
                    _datatype="SinglelineText" _fieldalias="{en:'Code',zh_CN:'公文标题',zh_TW:''}">关于王明同志的任命通知</span></td>
              </tr>
              <tr height="30">
                <td style="width: 110px; border: 1px solid #FF0000; border: 1px solid #FF0000;text-align: center;">
                  <font style="color: rgb(255, 0, 0); font-size: 14pt;">公文类型</font>
                </td>
                <td style="width: 180px; border: 1px solid #FF0000;text-align: center; -ms-word-break: break-all;"></td>
                <td style="width: 110px; border: 1px solid #FF0000;text-align: center;">
                  <font style="color: rgb(255, 0, 0); font-size: 14pt;">行文类型</font>
                </td>
                <td style="border: 1px solid #FF0000;text-align: center; -ms-word-break: break-all;"></td>
              </tr>
              <tr height="30">
                <td style="width: 110px; border: 1px solid #FF0000;text-align: center;">
                  <font style="color: rgb(255, 0, 0); font-size: 14pt;">公文文号</font>
                </td>
                <td style="width: 180px; border: 1px solid #FF0000;text-align: center; -ms-word-break: break-all;"><span
                    id="tmplt_1337585977749F_GWWH" _fieldname="F_GWWH" _isfield="true" _datatype="SinglelineText"
                    _fieldalias="{en:'Code',zh_CN:'公文文号',zh_TW:''}">广2019040001</span></td>
                <td style="width: 110px; border: 1px solid #FF0000;text-align: center;">
                  <font style="color: rgb(255, 0, 0); font-size: 14pt;">归档文号</font>
                </td>
                <td style="border: 1px solid #FF0000;text-align: center; -ms-word-break: break-all;"><span
                    id="tmplt_1337585979933F_NBWH" _fieldname="F_NBWH" _isfield="true" _datatype="SinglelineText"
                    _fieldalias="{en:'Code',zh_CN:'归档文号',zh_TW:''}"></span></td>
              </tr>
              <tr height="30">
                <td style="width: 110px; height: 20px; border: 1px solid #FF0000;text-align: center;">
                  <font style="color: rgb(255, 0, 0); font-size: 14pt;">文件密级</font>
                </td>
                <td style="width: 180px; border: 1px solid #FF0000;text-align: center; -ms-word-break: break-all;"></td>
                <td style="width: 110px; height: 20px; border: 1px solid #FF0000;text-align: center;">
                  <font style="color: rgb(255, 0, 0); font-size: 14pt;">紧急程度</font>
                </td>
                <td style="border: 1px solid #FF0000;text-align: center; -ms-word-break: break-all;"></td>
              </tr>
              <tr height="30">
                <td style="width: 110px; height: 20px; border: 1px solid #FF0000;text-align: center;">
                  <font style="color: rgb(255, 0, 0); font-size: 14pt;">拟稿人</font>
                </td>
                <td style="width: 180px; border: 1px solid #FF0000;text-align: center; -ms-word-break: break-all;"><span
                    id="tmplt_1337589553641F_JWR" _fieldname="F_JWR" _isfield="true" _datatype="SinglelineText"
                    _fieldalias="{en:'Code',zh_CN:'拟稿人',zh_TW:''}">张三</span></td>
                <td style="width: 110px; border: 1px solid #FF0000;text-align: center;">
                  <font style="color: rgb(255, 0, 0); font-size: 14pt;">保密期限</font>
                </td>
                <td style="border: 1px solid #FF0000;text-align: center; -ms-word-break: break-all;"></td>
              </tr>
              <tr height="30">
                <td style="width: 110px; border: 1px solid #FF0000;text-align: center; font-family: &quot;宋体&quot;, Simsun;">
                  <font style="color: rgb(255, 0, 0); font-size: 14pt;">主送单位</font>
                </td>
                <td style="border: 1px solid #FF0000;text-align: center; -ms-word-break: break-all;" colspan="3"><span
                    id="tmplt_1337586001103F_SWDW" _fieldname="F_SWDW" _isfield="true" _datatype="SinglelineText"
                    _fieldalias="{en:'Code',zh_CN:'主送单位',zh_TW:''}">广联达</span></td>
              </tr>
              <tr height="30">
                <td style="width: 110px; border: 1px solid #FF0000;text-align: center; font-family: &quot;宋体&quot;, Simsun;">
                  <font style="color: rgb(255, 0, 0); font-size: 14pt;">抄报单位</font>
                </td>
                <td style="border: 1px solid #FF0000;text-align: center; -ms-word-break: break-all;" colspan="3"><span
                    id="tmplt_1337586005908F_CBDW" _fieldname="F_CBDW" _isfield="true" _datatype="SinglelineText"
                    _fieldalias="{en:'Code',zh_CN:'抄报单位',zh_TW:''}"></span></td>
              </tr>
              <tr height="30">
                <td style="width: 110px; border: 1px solid #FF0000;text-align: center;">
                  <font style="color: rgb(255, 0, 0); font-size: 14pt;">抄送单位</font>
                </td>
                <td style="width: 180px; border: 1px solid #FF0000;text-align: center; -ms-word-break: break-all;"><span
                    id="tmplt_1337586014473F_CSDW" _fieldname="F_CSDW" _isfield="true" _datatype="SinglelineText"
                    _fieldalias="{en:'Code',zh_CN:'抄送单位',zh_TW:''}"></span></td>
                <td style="width: 110px; border: 1px solid #FF0000;text-align: center;">
                  <font style="color: rgb(255, 0, 0); font-size: 14pt;">签发日期</font>
                </td>
                <td style="border: 1px solid #FF0000;text-align: center; -ms-word-break: break-all;"><span
                    id="tmplt_1337586091522F_QFRQ" _fieldname="F_QFRQ" _isfield="true" _datatype="DateType"
                    _fieldalias="{en:'Code',zh_CN:'签发日期',zh_TW:''}">2019年4月15日</span></td>
              </tr>
              <tr height="30">
                <td style="width: 110px; border: 1px solid #FF0000;text-align: center;">
                  <font style="color: rgb(255, 0, 0); font-size: 14pt;">发文单位</font>
                </td>
                <td style="width: 180px; border: 1px solid #FF0000;text-align: center; -ms-word-break: break-all;"><span
                    id="tmplt_1337586018388F_FWDW" _fieldname="F_FWDW" _isfield="true" _datatype="SinglelineText"
                    _fieldalias="{en:'Code',zh_CN:'发文单位',zh_TW:''}">广天下</span></td>
                <td style="width: 110px; border: 1px solid #FF0000;text-align: center;">
                  <font style="color: rgb(255, 0, 0); font-size: 14pt;">签发人</font>
                </td>
                <td style="border: 1px solid #FF0000;text-align: center; -ms-word-break: break-all;"><span
                    id="tmplt_1337586046937F_QFR" _fieldname="F_QFR" _isfield="true" _datatype="SinglelineText"
                    _fieldalias="{en:'Code',zh_CN:'签发人',zh_TW:''}">李四</span></td>
              </tr>
              <tr height="30">
                <td style="width: 110px; border: 1px solid #FF0000;text-align: center;">
                  <font style="color: rgb(255, 0, 0); font-size: 14pt;">印发单位</font>
                </td>
                <td style="width: 180px; border: 1px solid #FF0000;text-align: center; -ms-word-break: break-all;"></td>
                <td style="width: 110px; border: 1px solid #FF0000;text-align: center;">
                  <font style="color: rgb(255, 0, 0); font-size: 14pt;">印发份数</font>
                </td>
                <td style="border: 1px solid #FF0000;text-align: center; -ms-word-break: break-all;"><span
                    id="tmplt_1337586072443F_YFFS" _fieldname="F_YFFS" _isfield="true" _datatype="IntType"
                    _fieldalias="{en:'Code',zh_CN:'印发份数',zh_TW:''}">111</span></td>
              </tr>
              <tr height="30">
                <td style="width: 110px; border: 1px solid #FF0000;text-align: center;">
                  <font style="color: rgb(255, 0, 0); font-size: 14pt;">主题词</font>
                </td>
                <td style="width: 180px; border: 1px solid #FF0000;text-align: center; -ms-word-break: break-all;"><span
                    id="tmplt_1337586077888F_ZTC" _fieldname="F_ZTC" _isfield="true" _datatype="SinglelineText"
                    _fieldalias="{en:'Code',zh_CN:'主题词',zh_TW:''}">任命</span></td>
                <td style="width: 110px; border: 1px solid #FF0000;text-align: center;">
                  <font style="color: rgb(255, 0, 0); font-size: 14pt;">打印人</font>
                </td>
                <td style="border: 1px solid #FF0000;text-align: center; -ms-word-break: break-all;"></td>
              </tr>
              <tr height="63">
                <td style="width: 110px; border: 1px solid #FF0000;text-align: center; font-family: &quot;宋体&quot;, Simsun;">
                  <font color="#ff0000">附件</font>&nbsp;
                </td>
                <td style="border: 1px solid #FF0000;text-align: center;" colspan="3"><span id="tmplt_1553936357208F_GWFJ"
                    _fieldname="F_GWFJ" _isfield="true" _datatype="MultilineText"
                    _fieldalias="{en:'Code',zh_CN:'附件名称',zh_TW:''}">无</span></td>
              </tr>
              <tr height="63">
                <td style="width: 110px; border: 1px solid #FF0000;text-align: center; font-family: &quot;宋体&quot;, Simsun;">
                  <font style="color: rgb(255, 0, 0); font-size: 14pt;">审核意见</font>
                </td>
                <td style="border: 1px solid #FF0000;text-align: center;" colspan="3"></td>
              </tr>
              <tr height="63">
                <td style="width: 110px; border: 1px solid #FF0000;text-align: center; font-family: &quot;宋体&quot;, Simsun;">
                  <font style="color: rgb(255, 0, 0); font-size: 14pt;">审批意见</font>
                </td>
                <td style="border: 1px solid #FF0000;text-align: center;" colspan="3"></td>
              </tr>
              <tr height="63">
                <td style="width: 110px; border: 1px solid #FF0000;text-align: center; font-family: &quot;宋体&quot;, Simsun;">
                  <font style="color: rgb(255, 0, 0); font-size: 14pt;">签发意见</font>
                </td>
                <td style="border: 1px solid #FF0000;text-align: center;" colspan="3"></td>
              </tr>
              <tr height="63">
                <td style="width: 110px; border: 1px solid #FF0000;text-align: center; font-family: &quot;宋体&quot;, Simsun;">
                  <font style="color: rgb(255, 0, 0); font-size: 14pt;">会签意见</font>
                </td>
                <td style="border: 1px solid #FF0000;text-align: center;" colspan="3"></td>
              </tr>
            </tbody>
          </table>`,
      value6: ''
    }
  },
  methods: {
    setValue6 (name) {
      console.log(name)
      this.value6 = name
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
  .test {
    display: flex;
    justify-content: space-between;
    flex-wrap: wrap;
  }
  .test-right {
    width: 270px;
    margin-left: 20px;
  }
  .test-left {
    flex: 1;
    border-right: 1px solid #dcdee2;
  }
</style>
<style>

</style>
