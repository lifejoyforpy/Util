﻿using Util.Ui.Builders;
using Util.Ui.Configs;
using Util.Ui.Extensions;
using Util.Ui.Material.Cards.Builders;
using Util.Ui.Renders;

namespace Util.Ui.Material.Cards.Renders {
    /// <summary>
    /// 卡片内容渲染器
    /// </summary>
    public class CardContentRender : RenderBase {
        /// <summary>
        /// 配置
        /// </summary>
        private readonly IConfig _config;

        /// <summary>
        /// 初始化卡片内容渲染器
        /// </summary>
        /// <param name="config">配置</param>
        public CardContentRender( IConfig config ) : base( config ) {
            _config = config;
        }

        /// <summary>
        /// 获取标签生成器
        /// </summary>
        protected override TagBuilder GetTagBuilder() {
            var builder = new CardContentBuilder();
            Config( builder );
            return builder;
        }

        /// <summary>
        /// 配置
        /// </summary>
        protected void Config( TagBuilder builder ) {
            builder.Style( _config );
            builder.Class( _config );
            ConfigId( builder );
            ConfigContent( builder );
        }
    }
}