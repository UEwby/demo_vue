import Vue from 'vue';

import Skeleton from 'D:\\Dev\\demo_vue\\lavas\\wangby_lavas_base\\core\\Skeleton.vue';


export default new Vue({
    components: {
        
        Skeleton,
        
    },
    template: `
        <div>
            
            <skeleton id="skeleton" style="display:none"/>
            
        </div>
    `
});
