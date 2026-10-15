<p align="center">
  <img alt="achievement-banner" src="../assets/achievement.png" />
</p>

```text
 █████╗  ██████╗██╗  ██╗██╗███████╗██╗   ██╗███████╗███╗   ███╗███████╗███╗   ██╗████████╗
██╔══██╗██╔════╝██║  ██║██║██╔════╝██║   ██║██╔════╝████╗ ████║██╔════╝████╗  ██║╚══██╔══╝
███████║██║     ███████║██║█████╗  ██║   ██║█████╗  ██╔████╔██║█████╗  ██╔██╗ ██║   ██║
██╔══██║██║     ██╔══██║██║██╔══╝  ╚██╗ ██╔╝██╔══╝  ██║╚██╔╝██║██╔══╝  ██║╚██╗██║   ██║
██║  ██║╚██████╗██║  ██║██║███████╗ ╚████╔╝ ███████╗██║ ╚═╝ ██║███████╗██║ ╚████║   ██║
╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝╚═╝╚══════╝  ╚═══╝  ╚══════╝╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝   ╚═╝
```

<p align="center">
  <img src="https://img.shields.io/badge/Jellyfin-10.11_%7C_12.0-0b0b0b?style=for-the-badge&labelColor=000000&color=2b2b2b" />
  <img src="https://img.shields.io/badge/Type-Plugin-E50914?style=for-the-badge&labelColor=000000&color=E50914" />
  <img src="https://img.shields.io/badge/System-Achievements-0b0b0b?style=for-the-badge&labelColor=000000&color=2b2b2b" />
  <a href="https://github.com/ZL154/AchievementBadges_for_Jellyfin/releases/latest"><img src="https://img.shields.io/github/v/release/ZL154/AchievementBadges_for_Jellyfin?style=for-the-badge&labelColor=000000&color=2b2b2b&label=Release" /></a>
  <img src="https://img.shields.io/badge/License-MIT-0b0b0b?style=for-the-badge&labelColor=000000&color=2b2b2b" />
</p>

<!-- 语言切换：本文件是完整的中文翻译，并额外记录了本分支相对上游的改动。 -->
<p align="center">
  <img alt="简体中文" src="https://img.shields.io/badge/%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87-%E5%BD%93%E5%89%8D%E6%96%87%E6%A1%A3-E50914?style=for-the-badge&labelColor=000000&color=E50914" />
  <a href="../README.md"><img alt="English" src="https://img.shields.io/badge/English-README-0b0b0b?style=for-the-badge&labelColor=000000&color=2b2b2b" /></a>
</p>

<p align="center">
  <a href="https://github.com/ZL154/AchievementBadges_for_Jellyfin/actions/workflows/ci.yml"><img src="https://img.shields.io/github/actions/workflow/status/ZL154/AchievementBadges_for_Jellyfin/ci.yml?style=for-the-badge&labelColor=000000&label=CI" /></a>
  <a href="https://github.com/ZL154/AchievementBadges_for_Jellyfin/actions/workflows/codeql.yml"><img src="https://img.shields.io/github/actions/workflow/status/ZL154/AchievementBadges_for_Jellyfin/codeql.yml?style=for-the-badge&labelColor=000000&label=CodeQL" /></a>
  <a href="https://github.com/ZL154/AchievementBadges_for_Jellyfin/actions/workflows/security.yml"><img src="https://img.shields.io/github/actions/workflow/status/ZL154/AchievementBadges_for_Jellyfin/security.yml?style=for-the-badge&labelColor=000000&label=Security" /></a>
  <a href="https://scorecard.dev/viewer/?uri=github.com/ZL154/AchievementBadges_for_Jellyfin"><img src="https://img.shields.io/ossf-scorecard/github.com/ZL154/AchievementBadges_for_Jellyfin?style=for-the-badge&labelColor=000000&label=OSSF%20Score" alt="OpenSSF Scorecard" /></a>
  <a href="https://www.bestpractices.dev/projects/12937"><img src="https://img.shields.io/cii/level/12937?style=for-the-badge&labelColor=000000&label=Best%20Practices" alt="OpenSSF Best Practices" /></a>
</p>
# 🏆 Jellyfin 成就徽章（Achievement Badges for Jellyfin）

面向 Jellyfin 的完整进度、游戏化与成就系统：根据用户**真实的观看行为**给予奖励。可以把它理解为 Xbox 成就分（Gamerscore）、Letterboxd 与 Steam 个人资料定制的结合体，并且原生集成在你的媒体服务器里。

> **状态：** 持续开发中 —— **v2.4.2** 已发布：**类型与制片厂徽章终于按你实际观看的内容计数** —— 剧集现在会为制片厂徽章计数，TMDb 的复合类型（"Action & Adventure"、"Sci-Fi & Fantasy"）对其每个组成部分分别计数，制片厂的别名（"Walt Disney Pictures"、"HBO Max"）也会为其计数，每个条目只计一次 —— 此外还有手机端的好友聊天，以及一张能躲过目录裁剪的插件卡片图。详见 [v2.4.2 新特性](#-v242-新特性--统计你实际观看内容的类型和制片厂徽章)。v2.4.1 修好了 2.4.0 在 Jellyfin 12 上搞砸的问题（彻底失败的卸载、只能在隐私窗口打开的页面），把定向徽章上限变成了可配置项，新增顶部居中弹窗与隐藏账号选项，并让插件不再破坏服务器的 API 文档。v2.4.0 带来 **Jellyfin 12 支持**、**定向徽章**、**JellyEmu 游戏成就**，以及可分享卡片上的商店装饰。它建立在 2.3 的好友资料卡与卡片皮肤、2.2「你的界面，你做主」、2.1「开放媒体库」扩展与 2.0「选择你的装备」之上。

---

## 🔧 本仓库相对原版的修改

本仓库是 [ZL154/AchievementBadges_for_Jellyfin](https://github.com/ZL154/AchievementBadges_for_Jellyfin) 的**简体中文本地化分支**，基于上游 **v2.4.2** 源码修改，共涉及 31 个文件（+4412 / −503 行）。

**改动范围仅限「中文支持」与「排版可读性」，没有改动任何玩法逻辑、计分算法或数据结构** —— 徽章定义 `AchievementDefinitions.cs` **零改动**，服务层只增加了本地化调用。

### 1. 简体中文界面汉化

| 内容 | 位置 | 规模 |
|---|---|---|
| 界面文案 | `Pages/translations/{lang}.json` | **1524 个键** × 8 种语言 |
| 徽章标题与说明 | `Pages/translations/badges.{lang}.json` | **256 枚徽章** × 8 种语言 |
| 服务端直出文案 | 隐藏成就说明、`???` 占位、**35 条**错误/状态提示 | 8 种语言 |

补齐过程中发现上游有 **22 枚徽章**（Discography 5 枚 / Games 9 枚 / Hidden 8 枚）在**所有语言的翻译文件里都不存在**（连英文文件都没有），已一并补全。

### 2. 默认语言改为简体中文

- `Plugin.DefaultLanguageCode = "zh"`，`PluginConfiguration.DefaultLanguage` 默认值改为 `zh`
- 已安装用户通过一次性配置迁移（`ConfigSchemaVersion`）自动切换到中文；**迁移只执行一次**，之后在设置里改回英文会被尊重
- 简体中文只是**默认值**，不是锁定：语言仍可在「设置 → 语言」里随时切换，也支持每个用户独立设置

### 3. 服务端文案本地化机制

服务端拼装错误消息时**并不知道浏览器用的是哪一种语言**。为此新增了一套机制：

- `BadgeLocalizer.UiText(lang, key, fallback)` —— 服务端读取与客户端**同一份** `translations/{lang}.json`
- 错误响应同时返回稳定的 `MessageKey`（以及可选的 `MessageArgs` 占位符），由客户端就地翻译，**原有调用方一行都不用改**

### 4. 排版与可读性

中文在相同像素下比拉丁字母显得更小，因此做了针对性调整：

- 两个页面根节点增加**字号下限** `font-size: max(1em, 16px)` —— 外层本来就 ≥16px 时完全不生效
- 徽章卡片：标题 1.05→**1.18em**、说明 1.02em 并加大行高、进度文字放大
- 顶部分类栏：标签 **11px→15px** 并加粗，编号 9px→11px
- 卡片按钮「装备 / 卸下」：**10px→13px** 并加粗，内边距加大
- 「已装备 / 已锁定」状态字：11px→13px

### 5. 顺带修复的上游缺陷

汉化过程中暴露出几个与语言无关的隐藏缺陷，已一并修复：

| 现象 | 根因 |
|---|---|
| 后台设置**整页失效** | 改版布局脚本误用了另一个作用域的 `tr()`，运行时抛错中断 |
| 卡片外框文字**永远是英文** | 翻译字典与首次渲染存在竞态；生成出来的 HTML 不会被静态标记刷新 |
| 分区标题不翻译 | 改版布局给每个 `<summary>` 插入了图标子元素，翻译器会跳过「已有子元素」的元素 |
| 个人档案一直停在「加载中」 | 只有成功 / 加载失败两条路径会更新副标题，未检测到用户等分支不更新 |
| 若干硬编码英文 | 任务栏标题、商店按钮、刷新提示等未接入翻译 |

### 6. 关于版本号

Jellyfin 通过**版本号**判断插件是否需要更新，因此本地化构建以 **2.5.x** 发布，以便覆盖已安装的 2.4.x 版本；源码中的 `<Version>` 仍沿用上游的 `2.4.2`。

两个构建对应两个 Jellyfin 目标框架：

| Jellyfin | 目标框架 | 程序集版本 |
|---|---|---|
| 10.11.x | `net9.0` | 2.5.x**.0** |
| 12.x | `net10.0` | 2.5.x**.1** |

### 7. 未改动的部分

- 玩法、计分、数据库结构与存档格式
- 其他 7 种语言（en / fr / es / de / it / pt / ja）的**既有译文一字未改**，仅补入了新增的键
- 上游的 CI、发布流程、许可证与第三方声明

---

## 📑 目录

- [概述](#-概述)
- [v2.4.2 新特性 — 统计你实际观看内容的类型和制片厂徽章](#-v242-新特性--统计你实际观看内容的类型和制片厂徽章)
- [核心功能](#-核心功能)
  - [徽章系统](#-徽章系统)
  - [等级系统](#-等级系统)
  - [积分经济](#-积分经济)
  - [声望](#-声望)
  - [每日与每周任务](#-每日与每周任务)
  - [道具与积分商店](#-道具与积分商店)
  - [个人档案自定义](#-个人档案自定义)
  - [好友抽屉](#-好友抽屉)
  - [私信](#-私信)
  - [稀有度百分比标签](#-稀有度百分比标签)
  - [数据丢失恢复](#-数据丢失恢复)
  - [统计与可视化](#-统计与可视化)
  - [UI 集成](#-ui-集成)
  - [用户偏好](#-用户偏好)
  - [语言](#-语言)
  - [管理员功能](#-管理员功能)
  - [追踪](#-追踪)
- [自定义徽章](#-自定义徽章)
- [Tracearr 集成](#-tracearr-集成)
- [安全与运维](#-安全与运维)
- [安装](#-安装)
- [环境要求](#-环境要求)
- [故障排查](#-故障排查)
- [API 端点](#-api-端点)
- [截图](#-截图)
- [发布历史](#-发布历史)
- [往期发布说明](#-往期发布说明)
- [v2.4.1 新特性 — 修正 2.4.0 的错误，并提供一个可以调高的上限](#-v241-新特性--修正-240-的错误并提供一个可以调高的上限)
- [v2.4.0 新特性 — Jellyfin 12、定向徽章、游戏](#-v240-新特性--jellyfin-12定向徽章游戏)
- [v2.3.1 新特性](#-v231-新特性)
- [v2.3.0 新特性 — 好友与基础能力](#-v230-新特性--好友与基础能力)
- [v2.2.0 新特性 — 你的界面，你做主](#-v220-新特性--你的界面你做主)
- [v2.1.3 新特性](#-v213-新特性)
- [v2.1.0 新特性 — 开放媒体库](#-v210-新特性--开放媒体库)
- [支持本项目](#-支持本项目)
- [致谢与鸣谢](#-致谢与鸣谢)
- [许可证](#-许可证)

---

## ✨ 概述

涵盖 35+ 个类别中的 **200 多项内置成就**、从新手到不朽的 10 级等级阶梯、带有连击、声望、每日/每周任务的完整积分经济体系、一个 **内置 70+ 种外观的积分商店**、道具消耗品、带私信功能的好友抽屉，以及自定义徽章、季节性挑战、webhook 通知和完整审计日志等管理员强力功能。

设计上可与 NetFin、ElegantFin、StarTrack 等现代 Jellyfin 部署和主题干净集成。

---

## 🚀 v2.4.2 新特性 — 统计你实际观看内容的类型和制片厂徽章

类型和制片厂徽章现在会统计剧集、TMDb 为电视剧给出的复合类型，以及同一制片厂使用的多个名称。在真实服务器上，这次升级解锁了用户早已达成却从未获得的徽章。**从 v2.4.x 直接升级即可 — 无需迁移。** 完整说明见 [docs/release-notes/v2.4.2.md](release-notes/v2.4.2.md)。

### 🏷️ 类型与制片厂徽章（#154）

- **电视剧集会计入制片厂徽章。** Jellyfin 把制片厂信息保存在剧集上，而不是它的单集上，因此 *不只是电视*、*BBC老阿姨* 和 *网飞观影* 之前只能看到电影。现在单集会在实时统计和观看历史扫描中继承其所属剧集的制片厂。
- **复合类型会为每个组成部分分别计入。** TMDb 为剧集给出 “Action & Adventure” 和 “Sci-Fi & Fantasy”，而 *动作英雄*、*科幻学者* 和 *奇幻永恒* 之前一直匹配不上。“Sci-Fi” 现在也会计入 “Science Fiction”。
- **制片厂的其他名称也会计入。** 制片厂徽章以整词匹配制片厂 — “Walt Disney Pictures” 计入 Disney，“HBO Max” 计入 HBO，“BBC Film” 计入 BBC — 另外还包括 “Home Box Office”、“British Broadcasting Corporation” 和 “Ghibli”。
- **一个项目每个徽章只计一次**，无论它匹配了多少个名称。

**更新后会有什么变化：** 已经在观看历史中的记录会开始计入，因此进度会跳升，徽章可能当场解锁。在我们自己的服务器上，这次升级在 23 个档案中解锁了 11 个类型徽章，没有任何人的进度下降。**自定义徽章以相同方式匹配**，因此一个自定义的 “War” 徽章现在会统计 “War & Politics” 剧集。本次更新之前的剧集播放没有保存制片厂，因此制片厂徽章的电视部分从现在开始计入。

### 📱 其他小修复

- **好友聊天的消息输入框不再被手机导航栏遮挡（#147）。** 抽屉会采用实际可见的高度，并与状态栏和手势栏保持距离。
- **即使经过目录裁剪也依然完好的插件卡片图片（#146）。** Jellyfin 之前会把 README 横幅裁剪到只剩中间部分，切掉了文字、丢掉了奖杯；现在卡片有了自己专属的图片。

衷心感谢 **[@mattsigal](https://github.com/mattsigal)** 在他在此提交的第一个 PR（#154）中修复类型和制片厂问题，感谢 **[@camarigor](https://github.com/camarigor)** 审阅并测试该修复、并在此基础上加入每项目只计一次的统计，还带来了手机（#149）和卡片（#148）的修复；也感谢 **[@Roboatlas21](https://github.com/Roboatlas21)** 完成 #146 和 #147。

---

## 🧩 核心功能

### 🏅 徽章系统

- **200+ 项内置成就**，覆盖以下类别：电影、剧集、狂追、夜间观看、晨间、午后（12-17 时）、黄金时段（19-22 时）、周末、探索、连续、剧集/电影马拉松、时代、世界、语言、类型、时长、总时长、节日（圣诞节、新年、万圣节、开斋节、情人节、复活节、农历新年、排灯节、美国感恩节、独立日、篝火之夜、节礼日、母亲节、父亲节）、库完成度、忠诚度、人物、重看、动漫、制片厂专家、试播与追完，以及隐藏类别
- **8 个 v2.0 彩蛋徽章** — *一周年、深夜贤者、四连映、破晓之音、全领域观察者、至尊档案员、冷门佳作、长篇马拉松*（解锁前不会显示）
- **18 个音乐徽章（v2.1.0）** — 播放次数、收听小时数，以及独特的专辑 / 艺术家 / 流派 / 年代。音频播放与视频一样需要通过 80% 真实收听门槛。
- **8 个图书徽章（v2.1.0）** — 完成的图书数、有声书收听小时数，以及完成的系列。有声书播放按照 **有声书计入策略** 处理（默认仅图书 / 仅音乐 / 两者皆可）。
- **改进的动漫检测（v2.1.0，#25）** — 同时匹配项目 *及其父剧集* 上的 **类型 *和* 标签**，媒体库 / 类型 / 标签均可由管理员配置。
- **管理员编写的自定义徽章（v2.1.0）** — 跨任意指标的复合 AND/OR 条件；参见 [自定义徽章](#-自定义徽章)。
- **定向徽章（v2.4.0，#107）**：把徽章指向某一个特定的剧集、季、合集、播放列表、专辑或项目；参见 [定向徽章](#定向徽章)。
- **可分享卡片上的商店外观（v2.4.0，#42）**：已装备的自定义称号和徽章边框会显示在可分享的个人档案卡和好友抽屉的档案卡上，并遵循与已装备徽章相同的隐私开关。
- **游戏成就（v2.4.0，#115）**：通过 JellyEmu 游玩的游戏的场次、时长、不同游戏和平台，以及按平台、按开发商和按游戏的自定义徽章；参见 [游戏成就](#游戏成就jellyemu)。
- **6 个稀有度层级** — 普通、不普通、稀有、史诗、传说、神话
- **隐藏/秘密徽章** 在解锁前显示为 `???`
- **媒体库完成度里程碑**，可自动适配任意媒体库结构
- **按人追踪** — 导演和演员亲和度徽章
- **按类型追踪** — 带专属徽章的唯一类型计数器。自 v2.4.2 起，TMDb 的复合类型会为每个组成部分分别计入（“Action & Adventure” 计入 *动作英雄*，“Sci-Fi & Fantasy” 计入 *科幻学者* 和 *奇幻永恒*），“Sci-Fi” 会计入 “Science Fiction”，并且一个项目无论匹配多少个类型，每个徽章都只计一次
- **时代 / 国家 / 语言** 细分，来自项目元数据
- **观看连续** — 当前连续和最佳连续徽章
- **每日登录连续** — 为持续访问提供的忠诚度奖励

值得关注的子合集：

- **🎌 动漫层级（5 个徽章）** — 基于类型标签检测（任何包含 `"anime"` 的类型，不区分大小写）。在 5 / 15 / 50 / 200 / 500 个动漫项目时解锁 *动漫好奇者 / 动漫爱好者 / 御宅族 / 动漫老兵 / 至尊御宅*。
- **🎬 制片厂专家（6 个徽章）** — Letterboxd 风格的“我看了很多 A24”徽章，以 `BaseItem.Studios` 作为参数。自 v2.4.2 起（#154），制片厂以整词匹配，因此 “Walt Disney Pictures” 计入 Disney、“HBO Max” 计入 HBO（另外还有 “Home Box Office”、“British Broadcasting Corporation” 和 “Ghibli”），**电视剧集会随其所属剧集的制片厂一起计入**，并且一个项目每个徽章只计一次。v2.4.2 之前的剧集播放没有记录制片厂，因此电视侧的计入从该次更新开始：

| 徽章 | 制片厂 | 阈值 |
|---|---|---|
| 千与千寻 | Studio Ghibli | 5 |
| A24追随者 | A24 | 15 |
| 不只是电视 | HBO | 25 |
| 网飞观影 | Netflix | 50 |
| BBC老阿姨 | BBC | 25 |
| 米奇之家 | Disney | 50 |

- **🎟️ 试播与追完（6 个徽章）** — 你观看了 S1E1 的每一部剧集都会被加入该用户的“已看试播集”集合。如果之后又看了该剧集的任何其他单集，该剧集就升级为“越过试播集继续观看”。*试播员 / 橱窗购物者 / 承诺恐惧症* 对应你试看 5 / 20 / 50 部剧集后弃剧；*上钩了 / 完美着陆 / 始终在线* 对应你在 5 / 20 / 50 部剧集上越过试播集继续观看。

> **回填也会计入这些** — 观看历史回填任务会把 `Studios`、`SeriesId`、`SeasonNumber`、`EpisodeNumber` 传递给成就服务，因此历史单集会为动漫 / 制片厂 / 试播徽章计入。时段分桶只统计新场次。

### 🎖️ 等级系统

- **10 个层级**，从 新手 → 初学者 → 观众 → 常客 → 爱好者 → 追剧狂 → 鉴赏家 → 大师 → 传奇 → 不朽
- 等级根据你的成就积分计算，并带有到下一层级的进度条
- **主题解锁** — 成就页面会随着你的攀升而改变渐变 / 边框颜色
- **自定义等级称号（v2.0 新增）** — 装备一个外观称号（影迷 / 策展人 / 品味大师 等）来替换自动生成的层级名称
- 侧边栏徽章展示 + 头部圆点让你一眼看到当前已装备的徽章

### 💰 积分经济

- 每次播放都会向 **积分银行** 累积 5 点基础分数
- **连击倍率** — 15 分钟内的连续观看最高可叠加 +100% 加成
- **花费银行积分** 直接购买已锁定徽章，**或在全新商店中购买道具 + 外观（v2.0）**
- **赠送积分** 给你服务器上的其他用户
- **每日登录奖励（v2.0）** — 每个 UTC 日的首次真实观看 +10 积分
- 基于稀有度的徽章计分（10-150 分），并按声望等级缩放

### ⭐ 声望

- 达到传奇等级（12,000 积分）即可解锁声望
- **重置徽章 + 计数器**，但保留你的终身积分，并授予一颗声望之星
- 每个声望等级会为未来的徽章解锁增加 **+50% 积分倍率**
- 在个人档案和排行榜上可见

### 🎯 每日与每周任务

- **3 个并行的每日任务**，从 12 个内置模板中轮换
- **3 个并行的每周任务**，从 8 个内置模板中轮换
- 确定性轮换 — 服务器上的每个人每天/每周都拿到相同的任务
- 完成任务会向积分银行入账
- **重掷（v2.0 新增）** — 每个 UTC 日 1 次每日重掷，每个 ISO 周 1 次每周重掷。禁用状态的胶囊按钮表示你已用过，下次重置时恢复。
- **管理员任务自定义** — 在管理员页面添加 / 编辑 / 删除每日 + 每周任务，按 Id 替换内置任务，或禁用你的服务器无法满足的内置任务

### ⚡ 道具与积分商店

- **3 种消耗型道具** — 经验加成、双倍积分、连胜冻结
- **70+ 种外观物品**，分为 6 类 — 主题、徽章边框、称号、头像、背景、个人边框
- **Steam 风格的商店界面**，带精选轮播、实时预览、里程碑进度条、“还需要 N 积分”的可负担性提示
- **每日登录奖励** 会在每个 UTC 日首次 ≥80% 真实观看时随机掉落一个道具
- 所有购买都会记入审计日志；管理员测试工具可在无需刷观看的情况下直接发放物品

### 🎨 个人档案自定义

- **14 种个人档案主题** — 用 14 种风格中的任意一种重绘整个成就页面
- **7 种徽章边框** — 为已装备的徽章添加动画边缘
- **10 种自定义等级称号** — 3 种自动解锁 + 7 种仅限商店
- **14 种头像** — 用 emoji 替换等级奖章图标
- **8 种动画背景** — 4 个 CSS + 4 个 HD MP4 视频循环，视口固定并带暗化遮罩
- **6 种个人档案边框** — 英雄卡片上的动画效果
- **所有人都能看到（v2.4.0）** — 每一件已装备的外观都会显示在你的可分享档案卡上，以及好友从抽屉打开的那张卡上，并遵循与已装备徽章相同的隐私开关。参见 [v2.4.0 新特性](#-你装备的一切都会显示在卡片上42)。

### 👥 好友抽屉

- **双向** 好友关系，带有完整的 **请求 / 接受** 流程 — 没有人能悄悄关注你
- **全局悬浮按钮** 锚定在每个 Jellyfin 页面的左下角 — 不只是成就标签页。它会在 `/dashboard` + `/plugins` 页面以及媒体播放期间自动隐藏；一旦离开任一状态就立即重新出现
- **Xbox 指南风格的侧边抽屉**，包含四个子标签：好友 / 请求 / 查找 / 消息
- **个人档案卡** — 悬停在姓名上可查看摘要，点击可固定一张更大的卡片：等级、完成度、积分、连续、已装备徽章，以及自 v2.4.0 起该好友的自定义称号、徽章边框、主题点缀、个人档案边框和头像
- **悬停/点击个人档案卡（v2.3.0，#76）** — 悬停好友的姓名或头像会打开一张摘要卡（等级层级、完成度、积分、最佳连续、已装备展示）；点击会固定一张更大的卡片，按 Escape 或点击外部即可关闭，并且可用键盘操作。它由公开摘要端点提供，并受同样的排行榜退出设置约束，因此不会额外暴露任何信息
- **Jellyfin 个人资料图片头像**，显示在每个好友行上（未设置图片时回退为首字母）
- **在线 / 离线** 状态，实时取自 Jellyfin 的 `ISessionManager`，并带有 15 分钟的宽限窗口，因此随意浏览也算在线（而不只是正在播放）
- **正在播放** 显示 — 查看每位在线好友正在观看的剧集 + 单集标题
- **离线 — 最后观看 X** — 离线好友现在会显示他们最近观看的内容（与在线的“正在观看 X”呈现方式对应）。由 `IUserDataManager` 支持，并通过基于反射的 `LastPlayedDate` 查找实现
- 每位好友的 **已装备徽章** 显示在其所在行旁边（遵循他们的隐私偏好）
- 查找标签页中的 **输入即搜索** 用户选择器（而不是一个列出所有服务器用户的巨大下拉菜单）
- 当有人向你发送好友请求时，悬浮按钮 + 请求标签页上会显示 **红色未读角标**
- 好友行上的 **互相** 标记；如果对方已经向你发送过请求，**自动接受** 就会生效
- 用户设置中的 **隐私开关**：*对好友显示为离线*（始终将你显示为离线）、*隐藏我正在观看的内容*（仍然在线，但隐藏剧集/单集），以及 *离线时隐藏我的最后观看记录*。这些在服务器端由 `FriendsService.BuildFriendRow` 强制执行 — 客户端篡改无法绕过
- **紧凑的请求行** — 接受 / 拒绝 / 取消按钮仅有图标并带提示，因此请求标签页在视觉上不会臃肿
- 抽屉会跟随 经典/改版 切换 — 它会设置 `body[data-ab-style="revamp"]`，以便同一套令牌全局生效
- **手机安全（v2.4.2，#147）** — 抽屉会采用实际可见的高度，因此当地址栏显示时，聊天的消息输入框不再滑到 Android 导航栏后面，抽屉和好友按钮也都会避开状态栏和手势栏（`env(safe-area-inset-*)`）

### 💬 私信

内置于好友抽屉中的 Xbox 指南风格聊天。没有外部服务，没有 WebSockets，一切都存储在你自己的服务器上。

- **消息标签页** 位于 好友 / 请求 / 查找 旁边，会话按最新优先排序，带头像、最后一条消息预览 + 时间戳，以及每个会话的未读计数
- **一对一私信** 和 **群聊**（2–20 名参与者，可命名，支持重命名 + 退出 + 成员列表）
- **图片附件** — PNG / JPEG / GIF / WebP，最大 8 MB，服务端进行魔数校验，因此没人能把重命名为 `.png` 的 `.exe` 偷带进来。点击即可放大的灯箱
- **已读回执** — 单个绿色 ✓ 表示已送达，双绿色 ✓✓ 表示已读。按参与者维护 `readBy` 映射，因此群组回执也能正常工作
- **编辑和删除** 你自己的消息，通过 WhatsApp 风格的下拉菜单 — 点击你自己气泡的任意位置即可打开菜单，编辑窗口为 24 小时
- 聊天齿轮菜单中的 **清空会话** 按钮（清空双方，带确认对话框）
- **屏蔽用户** — 双向生效；已有消息保留，新消息被拒绝。存储在 `UserAchievementProfile.Preferences.BlockedUsers` 中
- **按对端静音**（仅存于 localStorage，不经过服务器往返）+ 独立设置面板中的 **按用户偏好**：
  - 消息通知总开关
  - 消息提示音（细微的 Web Audio 铃声，不使用音频文件）
  - **播放时静音** — 在 Jellyfin 视频播放器处于活跃状态时抑制通知
- **通知**：
  - 应用内弹窗通知（顶部居中，5 秒后自动消失，点击可打开该会话）
  - 当标签页不可见且已授予权限时使用浏览器 Notification API
  - 收到消息时播放提示音
- **未读指示器** — 好友列表中聊天按钮上的脉冲红点 + 消息标签页上的计数胶囊 + 悬浮好友按钮上的合并角标
- **抗闪烁渲染** — 基于内容哈希；聊天窗格只在确实发生变化时才重绘，从而保持滚动位置
- **自动轮询** — 打开的聊天内 6 秒，消息标签页 8 秒，抽屉关闭时 20 秒；全部都很轻量，全部受 `[Authorize]` 保护
- **速率限制** — 每位发送者每分钟 20 条消息，每条消息最多 1000 个字符，每个会话最多 2000 条消息的 FIFO 上限
- **好友关系门槛**：只有互为好友的人才能私信；群组创建者只能添加自己的好友。管理员的 `FriendsSimpleMode` 会把整个服务器当作一个好友列表，私信也是如此（开启 #138 选项时，仅在彼此可见的用户之间）
- **存储** — 磁盘上的单个 `messages.json` + `attachments.json` + `attachments/<id>.<ext>`，位于 `plugins/configurations/achievementbadges/` 下。通过临时文件 + `File.Move` 实现原子写入，因此发送过程中崩溃不会损坏存储。消息在服务器重启后依然保留

### 🏅 稀有度百分比标签

- 成就页面上的每张徽章卡都会显示一个彩色标签，标明 **你服务器上解锁了该徽章的用户百分比**
- **绿色 ≥ 50%**（在你服务器上很常见）、**琥珀色 10–50%**（不常见）、**红色 < 10%**（稀有 / 值得炫耀）
- 数据来自 `/badges/rarity-stats` 端点，带有 5 分钟的服务端缓存，因此不必在每次页面加载时重新扫描每个档案
- 稀缺度信号让用户一眼就能看出“这个服务器上没有别人拥有这个徽章”

### 💾 数据丢失恢复

- `Load()` 会依次尝试 **主 `badges.json` → `.bak` → `.recovery`**，然后才放弃。主文件不稳定但有干净备份时会静默恢复
- 每次成功保存时都会轮换 `.bak`
- 当主文件被隔离时，`.recovery` 会捕获会话内状态，因此重启永远不会像是被彻底重置
- `LastLoadSummary` 通过 `/test` 端点暴露，因此管理员可以看到恢复活动
- 无法解析的主文件会被隔离到 `badges.json.corrupt-<timestamp>`（不删除），以便手动恢复

### 📊 统计与可视化

- **回顾标签页** — 每周 / 每月 / 每年细分，含热门类型、导演、演员
- **年度总结** — Spotify 风格的年终回顾，包含主视觉、你的数字、你的亮点、你的最爱
- **观看热力图** — GitHub 风格的日历（30/90/180/365 天范围），按强度着色
- **类型雷达图** — 你的类型分布的 SVG 蛛网图
- **观看时钟** — 你实际观看时间的 24 小时极坐标图
- **统计快照** — 已解锁 / 积分 / 最佳连续 的直方图
- **分类排行榜** — 积分、电影、剧集、小时、最佳连续、剧集系列

### 🏠 UI 集成

- **侧边栏入口** 自动注入到 Jellyfin 导航菜单中（重启后在 Web、iOS 和 Android 上均可使用）
- **Jellyfin 12**：现代布局没有导航抽屉，因此该入口位于头像菜单中、就在个人资料下方，而已装备条位于工具栏中；旧布局（desktop-legacy、mobile-legacy、TV）保留抽屉入口。
- **已装备徽章展示** 位于头部 + 个人档案中（槽位数可配置，1-10），并用你已装备的徽章边框环绕
- **Xbox 风格解锁弹窗通知**，按稀有度着色（6 个层级），Xbox 徽标 → 奖杯替换，闪光扫过，以及稀有及以上解锁时的彩带
- **成就音效** — 普通/不普通使用 Xbox 360 铃声，稀有/史诗/传说/神话使用稀有的 Xbox One 铃声
- **钻石精灵图** 用于传说/神话解锁（147 帧旋转水晶动画）
- **可配置的解锁爆发** — 将同时发生的解锁合并为一条积分/数量摘要（默认），或分别播放每个成就动画
- **按设备的弹窗通知投递** — 选择所有已登录设备（默认）或仅选择获得该成就的 Jellyfin 设备
- **播放期间的弹窗通知** — 通过播放事件钩子 + DOM 回退，解锁会在获得后约 1 秒内触发
- **管理员弹窗通知预览** — 为每个稀有度层级提供测试按钮
- **独立成就页面** 位于 `#/achievements`，带有新的 **装备标签页（v2.0）**，用于管理道具、商店和外观
- **可选页面宿主** — 在 Custom Tabs 内复用同一页面，或用 Plugin Pages 注册它；两者都由管理员主动启用，且原生页面始终可用
- **模块化的按用户导航** — 可独立显示或隐藏 Custom Tabs 入口、Plugin Pages 入口和头部奖杯，互不影响，也不影响成就追踪
- **可分享的个人档案卡（三种皮肤，v2.3.0）** — 服务器渲染的 HTML，位于 `/Plugins/AchievementBadges/users/{id}/profile-card`，为 **Console**（默认）、**Metro** 或 **Aurora Spine**，每一种都以拥有者的等级颜色作为点缀色。用户在偏好设置中选择自己的皮肤；`?style=` 可按链接覆盖，未指定样式的请求会回退到拥有者的选择
- **好友浮层样式（v2.3.0）** — 抽屉的个人档案卡有详细和紧凑两种布局，按用户选择
- **经典 / 改版 切换** — 插件渲染的每个界面都有 经典/改版 切换（`ab-style-pref` localStorage）：
  - **改版** — 杂志跨页式主视觉，巨大的 Geist 700 等级名称，220px 锥形完成度圆环，非对称统计网格，带章节编号的标签页（`01 / MY BADGES`、`02 / QUESTS`……），控制面板式筛选条，环境漂移光球，胶片颗粒叠层，每日连续脉冲，等级名称微光，整页入场级联
  - **经典** — 你熟悉的 v1.8.10 外观
  - 好友抽屉也跟随该切换。**管理员页面** 有 HUD 角括号、神话 + 传说卡片上的锥形边缘光泽、动画式 KPI 数字递升、按层级错开的显示。
- **改版管理员操作条** — 使用我的账号 / 刷新 / 模拟播放 按钮 + 实时状态横幅位于改版模式下个人区的顶部。像“扫描所有用户”这样的长时间操作会以状态文本可见地脉动。

### ⚙️ 用户偏好

成就页面上的齿轮图标会打开一个带自动保存的完整设置面板：

- **弹窗通知控制** — 启用/禁用弹窗通知、声音、彩带、里程碑通知
- **解锁弹窗通知样式** — 合并摘要或逐个动画
- **弹窗通知设备范围** — 每个已登录客户端，或仅触发解锁的设备
- **最低弹窗通知稀有度** — 过滤掉普通的刷屏（全部 / 稀有+ / 史诗+ / 传说+）
- **隐私** — 从排行榜、档案比较、动态、声望榜中隐藏
- **导航集成** — 可独立显示/隐藏 Custom Tabs 入口、Plugin Pages 入口，以及头部/个人档案奖杯快捷方式
- **成就页面主题** — 默认、深色或浅色（旧版全站主题，与 v2.0 的个人档案主题外观相互独立）
- **防剧透模式** — 用 “???” 隐藏已锁定徽章的描述，让你自然地发现它们
- **已装备徽章槽位** — 选择你的展示中显示多少个徽章（1-10）
- **自动装备新解锁** — 新获得的徽章会自动填充空槽位
- **按用户语言选择器** — 覆盖管理员的全服务器默认设置
- **离线时隐藏我的最后观看记录** — 当你离线时，好友不会看到你最近观看的内容
- **播放时静音弹窗通知** + **播放时静音弹窗通知声音** — 在积极观看时让解锁动画/声音靠边站
- **消息通知 + 声音 + 播放时静音** — 完全掌控好友抽屉的聊天通知
- **可分享卡片皮肤（v2.3.0）** — 为你自己的个人档案卡选择 Console / Metro / Aurora Spine
- **好友浮层样式（v2.3.0）** — 悬停/点击卡片的详细或紧凑布局
- **弹窗通知位置（v2.3.0，#136）**：把解锁弹窗通知放在四个角落中的任意一个、顶部居中或底部居中，或保留为管理员选择的服务器默认值

### 🌍 语言

- **8 种语言** — English、Français、Español、Deutsch、Italiano、Português、中文 (简体)、日本語
- **约 2,200 个 UI 键** 已翻译，覆盖每个标签页（成就档案、统计、热力图、连续日历、声望排行榜、通知偏好、服务器统计、比较、排行榜、回顾、任务、管理员页面，以及每个 v2.0 装备界面）
- **全部 200+ 个内置徽章** 都已翻译 — 每种语言的标题 + 描述，并带有精心定制的文化引用（*Spirited Away* 徽章是 *Le Voyage de Chihiro* / *El Viaje de Chihiro* / *Chihiros Reise* / *La Città Incantata* / *A Viagem de Chihiro* / *千与千寻* / *千と千尋*）
- **徽章类别 + 稀有度** 也已本地化（“Binge” → “Marathon”，“Legendary” → “Légendaire” 等）
- **所有 v2.0 外观名称 + 描述** 都已翻译 — Cinephile / 影迷 / シネフィル / Cinéphile，以及每个主题、每个头像、每个背景
- 偏好设置中的 **按用户语言选择器**；管理员可设置一个全服务器默认值
- **地球语言选择器（v2.1.0）** — 管理员页面头部的一个地球下拉菜单可实时切换 UI 语言，并在重新加载后保持
- **完全本地化的管理员页面（v2.1.0）** — 完整性与反滥用部分以及 v2.0 测试工具部分（以前仅提供英文）现在已翻译为全部 8 种语言，新增的音乐 + 图书徽章也是如此
- 翻译在客户端 + 服务端加载（`BadgeLocalizer`），因此界面外壳和排行榜 / 展示 / 管理员网格 / 已装备展示中的徽章标题会一起本地化

### 🛠️ 管理员功能

- **功能控制** — 排行榜、比较、动态、声望、任务的开关
- **强制隐私模式** — 将所有用户覆盖为对全部社交功能隐藏
- **让登录界面中隐藏的账户不出现在其他用户的视图中（#138）**：启用了 Jellyfin 的 *在登录界面中隐藏此用户* 的账户，对其他所有人不会出现在排行榜、动态、好友搜索、比较和个人档案卡中。隐藏账户、管理员以及该账户已有的好友仍然可以看到它。默认关闭；即使开启，当所有账户都在登录界面隐藏时也不会改变什么，因为隐藏账户彼此可见
- **最多可装备徽章数** — 全服务器上限（1-10）
- **限制徽章可见性** — 用户只能看到自己的徽章
- **禁用徽章类别** — 隐藏整个类别（例如家庭服务器上的 “Late Night”）
- **自定义欢迎消息** — 显示在成就页面上的文本
- **重置用户进度** — 通过管理员端点清除特定用户的徽章（v2.4.0：面对格式错误或未知的用户 id 会拒绝，而不再返回 200）
- **可诊断的错误（v2.4.0）** — 管理员页面上的每次失败都会指出失败的是哪个请求，而找不到任何内容的观看历史扫描会提示你检查该账户的媒体库访问权限
- **启用/禁用单个徽章** — 当你的服务器无法满足某些条件时很有用
- **可视化徽章编辑器** — 基于表单的自定义徽章创建器
- **自定义徽章构建器（v2.1.0）** — 通过管理员表单创建简单徽章，或使用 **复合 AND/OR 条件** + 通过 `/Plugins/AchievementBadges/custom-badges` API 导入/导出。参见 [自定义徽章](#-自定义徽章)
- **每日徽章审计与清理（v2.1.0，#27）** — 扫描每个档案，找出 v2.1.0 之前的回填错误授予的限时徽章并清除它们（可被自然地重新获得）；记入审计日志
- 面向高级用户的 **JSON 编辑器** 替代方案
- **季节性挑战** — 带开始/结束日期的限时目标
- **挑战模板** — 一键添加 月度马拉松、十月恐怖、新年、暑期大片
- **Webhook 通知** — 每次解锁时向 Discord/Slack 兼容端点发送一次 POST
  - **HMAC-SHA256 签名** — 当管理员设置 `WebhookSigningSecret` 时，每个出站 POST 都会携带 `X-AchievementBadges-Signature: sha256=<hex>` + `X-AchievementBadges-Timestamp: <unix>`。接收方用 `HMAC(secret, timestamp + "." + raw_body)` 验证，并拒绝过期时间戳以防止重放。与 Stripe 和 GitHub 使用相同的信封格式。密钥为空 = 旧的未签名行为（向后兼容）。
- **审计日志** — 最近 5,000 条带时间戳的事件。`AdminAuditLogFilter` 会在每个 `RequiresElevation` 操作时写入一条记录 — 无需 grep 运行时日志就能回答“上周二是谁给谁解锁了 X”。
- **进度注入** — 为测试 / 赠送设置任意计数器值
- **v2.0 测试工具** — 向用户授予积分 / 道具 / 外观，为所有档案回填里程碑
- 管理员/配置页面上的 **服务器用户选择器**，便于进行多用户测试
- **手动撤销徽章（v1.9.8）** — 在需要时从特定用户身上取消授予某个特定徽章
- **完整性测试注入（v1.9.8）** — 在一个一次性用户上端到端验证每日上限和可疑速率审计标记
- **管理员认证锁定** — 所有管理员端点都需要提升的权限
- **默认 UI 样式 + 锁定（#43）** — 选择用户是默认使用 经典 还是 改版，并可选地把它设为唯一选项，让成就页面与你的 Jellyfin 主题相匹配。用户自己的选择会被记住而不是被抹除，因此当你解除锁定时它会回来
- **默认弹窗通知位置（#136）**：为所有未选择位置的用户设置解锁弹窗通知出现的位置；用户自己的选择始终优先
- **Tracearr 观看历史（#45）** — 设置 Tracearr URL 和 API 令牌，以计入媒体库扫描看不到的播放。参见 [Tracearr 集成](#-tracearr-集成)

### 🔒 追踪

- **观看历史回填** — 扫描现有的 Jellyfin 播放历史，在安装时追溯授予徽章
- **启动时自动评估** — 插件更新带来的新徽章，如果你现有的计数器已满足其条件就会自动解锁，无需手动扫描
- **实时播放追踪器** — 解锁会在观看过程中、超过 80% 完成度阈值后触发
- **真实观看计入门槛（v1.9.8）** — 播放事件需要累计 ≥80% 的播放 tick，且排除跳转；标记为已播放 + 跳到结尾 + 狂点不再计入徽章
- **60 秒最短时长** 过滤器，因此 Projectionist 前贴片和过渡片段无法计入
- **每日计入上限**（默认 200/用户/天，可配置）+ **`SuspiciousRatePerHour`** 审计标记（默认 30/小时，可配置），用于软性反滥用
- **重看检测** — 6 小时内去重，超过则计为一次重看
- **观看时长结转（v2.3.0）** — 部分观看会被留存下来，并能挺过一次会话中断、一次重启，以及一次媒体文件替换或画质升级（以媒体身份为键，#89），并带有管理员留存窗口（#87）；之后一次扫描会精确清除它所计入的那部分结转（#91/#92），因此已经计入的分钟数无法让之后的一次重看达标
- **媒体库 + 艺术家完成度接线（v2.3.0）** — 媒体库完成度徽章会在扫描期间重新计算（#80），每个艺术家的作品集完成度也会被追踪（#81），因此两者都能在正常使用中解锁
- **人物元数据提取** — 使用 `ILibraryManager.GetPeople()` 获取导演/演员

---

## 🎨 自定义徽章

> 于 **v2.1.0「开放媒体库」** 中加入。仅限管理员。所有接口都要求管理员权限。

用内置目录无法表达的**复合 AND/OR 条件**来定义你自己的徽章。插件配置页（控制台 → 插件 → Achievement Badges → *自定义徽章*）提供了用于**简单**徽章的表单（单一指标 + 阈值）。至于**复合**条件、图标控制以及导入/导出，请使用下面的 API。

### 条件模型

徽章的 `criteria` 是一棵树。一个节点**要么**是：

- 一个**叶子节点**：`{ "metric": "<Metric>", "threshold": <int>, "metricParameter": "<optional>" }` — 当指标值 ≥ 阈值时为真。
- 一个**复合节点**：`{ "operator": "And" | "Or", "children": [ <node>, ... ] }` — 当其子节点全部为真（And）或任意一个为真（Or）时为真。

限制：最大深度 **5**，每个徽章最多 **64** 个节点，每个实例最多 **500** 个徽章。

### 定向徽章

> 于 **v2.4.0** 中加入，来自 [#107](https://github.com/ZL154/AchievementBadges_for_Jellyfin/issues/107)。

有两个指标指向你媒体库中某个具体的对象，而不是某个汇总值：

- `ContainerCompletionPercent` — 某一个**剧集、季、合集、播放列表或专辑**的已播放条目数占条目总数的比例。阈值 100 表示“你已完成它”。
- `ItemPlayCount` — **某一个特定条目**被播放了多少次。阈值 1 表示“你看过这部电影”；更大的阈值适用于你反复回味的曲目。

两者都在 `metricParameter` 中给出目标，格式为 `"{guid}|{name}"`。配置页有一个媒体库选择器会代你写入。两半都是有意保存的：GUID 能挺过重命名，名称能挺过条目的删除与重新添加，因此徽章会重新解析自身并重写 GUID。

对于**任意一组剧集**，比如一部长寿剧的某条故事线，请创建一个 Jellyfin 合集，并让 `ContainerCompletionPercent` 徽章指向它。这样分组就留在 Jellyfin 原生功能里，而不是放在徽章编辑器的剧集列表中。

定向徽章会依据你已有的历史进行评估，因此你今天编写的徽章会立即为任何已经完成该目标的人解锁，无需扫描。所有徽章最多可以引用多少个不同的目标，是在配置页的 **自定义徽章** 下通过 **定向徽章上限** 设置的（1 到 1000，默认 50）。该页面会显示已启用徽章引用的目标数量与上限的对比，并列出超出上限的目标，这些目标不会被计算。每次播放都会用集合查找检查每个目标：剧集、季和文件夹对照已播放条目的祖先，合集和播放列表对照一个缓存的成员列表（容器变化时会刷新），因此在任何服务器上，数百个任意类型的目标都没有问题。

#### 模板 — 完成一部剧集

```jsonc
// POST /Plugins/AchievementBadges/custom-badges
{
  "name": "Straw Hat",
  "description": "Finish One Piece: Alabasta.",
  "rarity": "Epic",
  "media": "TV",
  "criteria": {
    "metric": "ContainerCompletionPercent",
    "metricParameter": "8f4e2a1b9c3d4e5f6a7b8c9d0e1f2a3b|One Piece: Alabasta",
    "threshold": 100
  }
}
```

### 游戏成就（JellyEmu）

> 于 **v2.4.0** 中加入，来自 [#115](https://github.com/ZL154/AchievementBadges_for_Jellyfin/issues/115)。

通过 [JellyEmu](https://github.com/Jellyfin-PG/JellyEmu) 游玩的游戏无需在 JellyEmu 侧做任何设置即可获得成就。JellyEmu 会把每个游戏会话作为一次播放会话上报给 Jellyfin，并为每个游戏打上 `JellyEmu`、`Game` 及其平台标签；本插件读取这些信息，并把每个会话按模拟器上报的值与插件自身时钟观测到的值中较小者计量，同时设有下限（`MinGameSessionSeconds`，默认 60），以免误点也算作一次游玩，以及上限（`MaxGameSessionMinutes`，默认 360），以免一个开着的标签页被当作通宵游玩。

内置在 **游戏** 分类下：会话阶梯（1、25、100）、不同游戏数（10、50）、小时数（10、100）以及平台数（3、8）。对于自定义徽章，构建器提供：

- `GamePlatformGames`，以平台标签为参数（`SNES`、`SegaGenesis`、`PlayStation`；拼写取自 JellyEmu，匹配时不区分大小写）：“玩 10 款 Sega Genesis 游戏”。
- `GameStudioGames`，以开发商或发行商为参数：“玩 5 款 Capcom 的游戏”。
- `GameHours`，以某个具体游戏为目标，像其他定向徽章一样在选择器中选取：“在这款游戏中游玩 30 小时”。

有两点限制值得了解：游玩时间从安装此版本的那一刻起计算，因为游戏不携带可用于重建历史的已播放标记；另外，这里不读取 RetroAchievements，它的解锁无法在 JellyEmu 的浏览器模拟器中发生（参见 #115 的讨论）。

### 模板 — 简单徽章

```jsonc
// POST /Plugins/AchievementBadges/custom-badges
{
  "name": "Cinephile",
  "description": "Watch 100 films.",
  "rarity": "Rare",            // Common | Uncommon | Rare | Epic | Legendary | Mythic
  "media": "Film",             // Film | TV | Music | Book | Anime | Multi
  "iconUrl": "",               // optional external https URL; blank = default trophy
  "enabled": true,
  "criteria": { "metric": "MoviesWatched", "threshold": 100 }
}
```

### 模板 — 复合（AND / OR）

```jsonc
{
  "name": "Renaissance Viewer",
  "description": "Watch 100 films AND listen to 50 music tracks.",
  "rarity": "Epic",
  "media": "Multi",
  "enabled": true,
  "criteria": {
    "operator": "And",
    "children": [
      { "metric": "MoviesWatched",   "threshold": 100 },
      { "metric": "MusicPlaysTotal", "threshold": 50 }
    ]
  }
}
```

嵌套示例 — *“（完成 5 部恐怖剧集 或 10 小时有声书）且观看 25 个动画条目”*：

```jsonc
{
  "name": "Eclectic",
  "description": "Genre-spanning dedication.",
  "rarity": "Legendary",
  "media": "Multi",
  "enabled": true,
  "criteria": {
    "operator": "And",
    "children": [
      {
        "operator": "Or",
        "children": [
          { "metric": "SeriesCompleted",         "threshold": 5,  "metricParameter": "Horror" },
          { "metric": "AudiobookListeningHours",  "threshold": 10 }
        ]
      },
      { "metric": "AnimeItemsWatched", "threshold": 25 }
    ]
  }
}
```

### 接口

| 方法 | 路由 | 用途 |
|---|---|---|
| `GET`    | `/Plugins/AchievementBadges/custom-badges`        | 列出全部 |
| `GET`    | `/Plugins/AchievementBadges/custom-badges/{id}`   | 获取单个 |
| `POST`   | `/Plugins/AchievementBadges/custom-badges`        | 创建（会分配新 id） |
| `PUT`    | `/Plugins/AchievementBadges/custom-badges/{id}`   | 更新 |
| `DELETE` | `/Plugins/AchievementBadges/custom-badges/{id}`   | 删除 |
| `GET`    | `/Plugins/AchievementBadges/custom-badges/export` | 将全部导出为 JSON |
| `POST`   | `/Plugins/AchievementBadges/custom-badges/import` | 批量导入（使用新 id） |
| `GET`    | `/Plugins/AchievementBadges/custom-badges/targets` | 定向徽章上限：配置值、实际生效的上限、取值范围、观测到的目标，以及超出上限的名称（#129） |
| `POST`   | `/Plugins/AchievementBadges/custom-badges/targets` | 设置上限（1-1000，超出会被截断）；返回最新的摘要（#129） |

### 全部指标

`AchievementMetric` 暴露的每一个值，共 71 个。标有 \* 的条目接受 `metricParameter`。

- **观看** — `TotalItemsWatched`, `MoviesWatched`, `SeriesCompleted`, `LongSeriesCompleted`, `VeryLongSeriesCompleted`, `RewatchCount`, `ShortItemsWatched`, `LongestItemMinutes`, `TotalMinutesWatched`, `SeriesSampledOnly`, `SeriesBingedAfterPilot`

- **连续与天数** — `DaysWatched`, `CurrentWatchStreak`, `BestWatchStreak`, `DaysLoggedIn`, `CurrentLoginStreak`, `BestLoginStreak`, `MaxEpisodesInSingleDay`, `MaxMoviesInSingleDay`, `MaxMinutesInSingleDay`

- **时段** — `LateNightSessions`, `EarlyMorningSessions`, `AfternoonSessions`, `PrimeTimeSessions`, `WeekendSessions`

- **多样性** — `UniqueGenresWatched`, `UniqueCountriesWatched`, `UniqueLanguagesWatched`, `UniqueDecadesWatched`, `UniqueLibrariesVisited`, `TopDirectorCount`, `TopActorCount`, `MaxLibraryItemCount`

- **完成度** — `LibraryCompletionPercent` \*, `LibrariesAt100Percent`, `BadgesUnlockedPercent`, `ArtistCompletionPercent` \*

- **音乐** — `MusicPlaysTotal`, `MusicListeningHours`, `UniqueMusicAlbums`, `UniqueMusicArtists`, `UniqueMusicGenres`, `UniqueMusicDecades`, `MusicGenrePlays` \*, `MusicGenreListeningHours` \*

- **书籍** — `BooksCompleted`, `AudiobookListeningHours`, `UniqueBookSeriesCompleted`

- **积分与声望** — `PrestigeLevel`, `LifetimeScore`, `BestComboCount`

- **按名称参数化** — `GenreItemsWatched` \*, `PersonItemsWatched` \*, `StudioItemsWatched` \*, `DecadeItemsWatched` \*, `DayOfWeekItemsWatched` \*

- **节日与日期** — `WatchedOnChristmas`, `WatchedOnNewYear`, `WatchedOnHalloween`, `WatchedOnEid`, `WatchedOnValentines`, `WatchedOnEaster`, `WatchedOnLunarNewYear`, `WatchedOnDiwali`, `WatchedOnThanksgiving`, `WatchedOnIndependenceDayUS`, `WatchedOnBonfireNight`, `WatchedOnBoxingDay`, `WatchedOnMothersDay`, `WatchedOnFathersDay`

- **动画** — `AnimeItemsWatched`

参数化指标在匹配各自的参数时不区分大小写。`metricParameter` 为 `"horror"` 的 `GenreItemsWatched` 只统计恐怖类条目；带 `"Movies"` 的 `LibraryCompletionPercent` 读取那一个媒体库，不带参数时则读取用户完成度最高的媒体库。`ArtistCompletionPercent` 同理，不带参数时读取该用户表现最好的艺术家。

自 v2.4.2 起，其中两个指标的匹配更宽松，并且无论一个条目的名称匹配到多少项，每个徽章都只把它计一次。`GenreItemsWatched` 会把 “Action & Adventure” 或 “Sci-Fi & Fantasy” 这类复合类型按每个部分分别计入，也会把 “Science Fiction” 计入 “Sci-Fi”。`StudioItemsWatched` 按整词匹配制片公司，因此 “Disney” 会计入 “Walt Disney Pictures”，“HBO” 会计入 “HBO Max”，而某一集会计入其所属剧集的制片公司。

---

## 📡 Tracearr 集成

可选。在插件设置中填写 **Tracearr URL** 和 **Tracearr API token**，在 Tracearr 的 Settings 下生成该令牌，之后观看历史扫描也会读取你的 Tracearr 历史记录。任一字段留空则不会有任何变化。

它的存在是因为媒体库扫描有两个自身无法弥补的盲区：

- **你已删除的媒体。** 扫描只读取仍然存在的条目上的 `IsPlayed`，因此一部你看过、后来又被删除的影片对它来说是不可见的。Tracearr 在播放发生时记录了下来，所以仍然保有这条记录。
- **你看过某部内容的次数。** `IsPlayed` 是布尔值，因此无论看过多少次都无法得出重看计数。这使得那些在已经观看了一段时间之后才安装插件的人无法获得重看徽章。

只有 Tracearr 认定已完成的播放才会被计入，并且每条都记在其实际发生的日期而非今天，因此一次陈旧的观看无法凭空造出连续记录。媒体库已经计入过的播放不会重复计数：已知条目的首次观看会被跳过，只有重复观看才会成为重看。

Tracearr 一侧无需任何配置。它使用的是现有的公开 v2 API。

---

## 🛡️ 安全与运维

- 每个控制器路由上都有**默认的类级速率限制**（`user-60-per-min`），冷却路由上保留更严格的覆盖值。静态资源路由（CSS / JS / 翻译 / 视频背景）通过 `[DisableRateLimiting]` 豁免，这样位于共享 NAT 之后的多用户家庭就不会共同耗尽该限制。
- 在匿名个人资料卡片端点上启用 **CSP** + `X-Content-Type-Options` + `X-Frame-Options` + `Referrer-Policy` + `Permissions-Policy`
- **每用户私信附件配额**（200 个文件 / 总计 200 MB）堵住了一条磁盘耗尽路径
- **SVG 清理器**会拦截可能在渲染过程中修改属性的 `<animate>` / `<set>` SMIL 元素
- **Webhook URL 的 DNS 解析**限制在 3 秒（原先为操作系统默认的 5-30 秒）
- **审计日志端点限制**在控制器层被钳制为 `[1, 1000]`
- **`MessagingService`** + **`AchievementBadgeService`** 实现了 `IDisposable`，因此插件重载时会释放防抖保存 Timer
- **单元安全回归测试** —— SSRF、IPv6 SSRF、协议方案拒绝、畸形 URL 拒绝、危险 SVG 元素拒绝、内联事件处理器拒绝、外部 DTD 拒绝、超大载荷拒绝、外部 `<use href>` 拒绝
- **GitHub Actions CI** 在每次 push、每个 PR 以及每周定时任务中运行测试 + `dotnet list package --vulnerable` + `gitleaks`
- **CodeQL** + **OpenSSF Scorecard** + **OpenSSF Best Practices Level 1**（项目 12937）
- **`SECURITY.md`**，包含完整威胁模型、信任边界、已部署防御清单、持续验证矩阵、漏洞披露 SLA 以及面向研究者的安全港条款
- **经 Sigstore 签名 + SLSA 构建来源证明的发布产物** —— 使用 `cosign verify-blob` 或 `gh attestation verify` 验证
- **可复现的 NuGet 还原** —— 通过 `RestorePackagesWithLockFile` 以哈希锁定每个传递依赖包，CI 在锁定模式下运行，因此任何漂移都会快速失败

### ⚡ 插件整体效率

- **防抖的 `Save()`**（位于 `AchievementBadgeService` 和 `MessagingService`）—— 把来自播放和私信热路径的连续磁盘写入合并为每 1.5 秒一次刷盘
- **`FriendsService.LastWatched` 缓存** —— 90 秒 TTL，在播放时失效，消除了每次调用好友列表时为每个好友执行 50 条目数据库查询的开销
- 生产环境存储使用 **`WriteIndented = false`**（`badges.json` 约小 50%）
- **嵌入资源缓存**用于 `client-script` + `asset` 路由 —— 每个进程只读取一次
- 资源上使用 **`Cache-Control: public, max-age=86400, immutable`**，并通过仅版本号变更来刷新缓存；视频背景使用 HTTP Range，因此浏览器只流式传输开始播放所需的字节
- 翻译上使用 **`Cache-Control: no-cache, must-revalidate`**（v2.0），这样用户在插件更新后无需强制刷新就能始终获取最新字符串
- 中间件标记快速路径（只扫描最后 4KB，而非完整正文）

---

## ⚙️ 安装

1. 进入 **Dashboard → Plugins → Repositories**
2. 添加：

```
https://raw.githubusercontent.com/ZL154/AchievementBadges_for_Jellyfin/main/manifest.json
```

3. 保存并刷新插件
4. 安装 **Achievement Badges**
5. 重启 Jellyfin
6. 进入 **Dashboard → Plugins → Achievement Badges → Settings**
7. 点击 **Scan watch history**（或 **Scan all users**），从已有的播放数据回填
8. 打开 **Achievements**（Jellyfin 12 在头像菜单中，10.11 在侧边栏中），或访问 `#/achievements` —— 然后试试 **Loadout** 标签页

---

## 🔧 环境要求

- **Jellyfin 10.11.x**（.NET 9）**或 Jellyfin 12.0.x**（.NET 10）。每次发布都会为每个分支各提供一个包，插件目录会为你的服务器挑选正确的那一个：版本 `x.y.z.0` 是 10.11 构建，`x.y.z.1` 是 12 构建。手动安装？请选择第 4 段版本号与你的服务器匹配的 zip。把服务器从 10.11 升级到 12 之后，插件更新会提供 `.1` 构建。
- **File Transformation 插件**（强烈推荐）—— 确保侧边栏、仪表盘 UI、个人资料展示和成就页面在 Jellyfin Web 的各次更新中都能可靠注入。没有它，大多数 UI 注入仍可通过插件自带的中间件工作，但 File Transformation 能提供最稳健的集成。

### 可选但有帮助

- **合适的元数据提供程序**（TMDb、OMDb）—— 导演/演员徽章要能生成所必需。如果你的媒体库没有刮削演职人员，基于 `item.People` 的徽章会一直为空
- **Home Screen Sections 插件** —— 让成就首页小组件能更可靠地注入
- **Custom Tabs 或 Plugin Pages** —— 成就页面的可选替代宿主；在插件设置的 **Page integrations** 下启用对应的集成。保存会安装/修复归属于本插件的 Custom Tabs 条目，且不会改动现有标签页；之后重启 Jellyfin。
  - Custom Tabs 通过修改服务器上 Jellyfin 首页的方式来注入标签页的内容面板，因此某个自带该页面副本的主题（例如 Abyss 的 Spotlight）可能导致标签按钮背后没有面板，过去这会表现为成就页面空白（#131）。插件现在会自行构建缺失的面板，因此该标签页仍能正常工作；由插件构建的面板带有 `data-ab-repaired-panel="true"`。在此类服务器上，其他 Custom Tabs 标签页仍然为空，因为只有这一个是我们该修复的。

### 各功能所需条件

| 功能 | 依赖 |
|---|---|
| 侧边栏 + 页头注入 | 无（可独立工作） |
| Custom Tabs 页面宿主 | Custom Tabs 插件 + 启用集成、保存并重启 Jellyfin |
| Plugin Pages 页面宿主 | Plugin Pages 插件 + 启用集成后重启 Jellyfin |
| 观看历史回填 | 条目上的已播放标记（Jellyfin 默认） |
| 类型徽章 | 带有 `Genres` 元数据的条目 |
| 导演/演员徽章 | 带有 `People` 元数据的条目（TMDb/OMDb 刮削） |
| 年代 / 十年徽章 | 带有 `ProductionYear` 元数据的条目 |
| 国家徽章 | 带有 `ProductionLocations` 元数据的条目 |
| 语言徽章 | 带有 `OriginalLanguage` 元数据的条目 |
| 时长徽章 | 已填充 `RunTimeTicks` 的条目 |
| 媒体库完成度 | 至少一个含有条目的媒体库文件夹 |
| Webhook 通知 | 一个 webhook URL（Discord、Slack 或通用） |
| 动态视频背景 | 支持 H.264 + `<video>` 静音自动播放的现代浏览器（所有常青浏览器） |

---

## 🔍 故障排查

### 侧边栏 / 弹窗通知 / UI 不显示

插件会在启动时把脚本注入 Jellyfin 的 `index.html`。如果 web 目录不可写，注入会静默失败，任何 UI 都不会加载（没有侧边栏条目、没有弹窗通知，也没有成就页面）。

**诊断：** 访问 `https://your-server/Plugins/AchievementBadges/test` —— JSON 响应会显示：
- `DiagIndexFound` —— 是否找到了 `index.html`
- `DiagIndexPatched` —— script 标签是否成功写入
- `DiagLastError` —— 如果修补失败，这里是确切的错误（通常是 `Unauthorized: Access denied`）

**常见原因：** 在 Docker 或 Linux 安装中，Jellyfin 对 `/usr/share/jellyfin/web/` 没有写权限。通过授予写权限来修复：

```bash
# Docker: run inside the container
chmod -R a+w /usr/share/jellyfin/web/

# Systemd: fix ownership
sudo chown -R jellyfin:jellyfin /usr/share/jellyfin/web/
```

然后重启 Jellyfin。插件会在下次启动时修补 `index.html`。

**无法（或不愿）让 web 目录可写？那就使用 JavaScript Injector 插件（v2.1.0，#26）。** 在 `/usr/share/jellyfin/web` 归 root 所有的裸机 Linux 上，请安装 [JavaScript Injector 插件](https://github.com/n00bcodr/Jellyfin-JavaScript-Injector)。下次启动时，如果磁盘上的修补失败，Achievement Badges 会**检测**到该插件，并把所需的准确脚本 URL 写入 `/Plugins/AchievementBadges/test` 诊断信息（`DiagJsInjectorGuidance`）和服务器日志。把下面三条粘贴到 JS Injector 的设置中 —— 每条一个条目：

```
/Plugins/AchievementBadges/client-script/sidebar
/Plugins/AchievementBadges/client-script/standalone
/Plugins/AchievementBadges/client-script/enhance
```

重启 Jellyfin，UI 就会通过 JS Injector 加载 —— 无需可写的 web 目录。（插件不会直接调用 JS Injector 的 API，因此这在各个 JS Injector 版本间都能持续可用；当目录*确实*可写时，磁盘修补仍是默认方式。）

**仍然无效？** 插件有一个中间件回退方案，会在运行时重写 `index.html`（无需写磁盘）。如果这条路也失败，请检查是否有反向代理（nginx/Caddy）缓存了安装插件之前的旧 `index.html`。清空代理缓存或重启代理。

### NixOS（只读的 `/nix/store`）

NixOS 从不可变的 Nix store 提供 Jellyfin 的 web 文件，因此磁盘修补器和中间件都无法修改 `index.html`。请使用 NixOS overlay 在构建时注入 script 标签：

```nix
nixpkgs.overlays = [
  (final: prev: {
    jellyfin-web = prev.jellyfin-web.overrideAttrs (finalAttrs: previousAttrs: {
      installPhase = ''
        runHook preInstall
        sed -i 's#</body>#<!-- achievementbadges-bootstrap --><script src="/Plugins/AchievementBadges/client-script/sidebar"></script><script src="/Plugins/AchievementBadges/client-script/standalone" defer></script><script src="/Plugins/AchievementBadges/client-script/enhance" defer></script></body>#' dist/index.html
        mkdir -p $out/share
        cp -a dist $out/share/jellyfin-web
        runHook postInstall
      '';
    });
  })
];
```

插件 DLL 从嵌入资源中提供这些 JS 文件 —— 那三个 `<script>` 标签只是告诉浏览器去加载它们。添加 overlay 后重新构建你的 NixOS 配置并重启 Jellyfin。

### 仪表盘的 API 文档页面空白（`/api-docs/openapi.json` 返回 500）

Jellyfin 会把服务器和每个已安装插件构建成**一份** OpenAPI 文档，其中每个类型都以其裸类名作为键。如果两个已加载的类型想要同一个名字，文档不会从中二选一 —— 它会失败，整份文档返回 500。徽章仍能正常工作，插件不会记录任何日志，唯一可见的症状就是 API 文档页面。

本插件在 2.1.0 到 2.4.0 期间导致过这个问题（`MediaType` 与 Jellyfin 自身的类型冲突），现在已不会。如果该页面在 **v2.4.1+** 上仍然损坏，那是另一个插件在冲突 —— 服务器日志会列出这两个类型：

```text
Can't use schemaId "$PluginConfiguration" for type "$Jellyfin.Plugin.A.PluginConfiguration".
The same schemaId is already used for type "$Jellyfin.Plugin.B.Configuration.PluginConfiguration"
```

`PluginConfiguration` 通常是元凶，因为大多数插件都这样命名其配置类。请向日志中出现的那一方插件报告；你的服务器上没有任何需要改动的地方。

### 视频背景无法播放

这 4 款高清视频外观需要浏览器支持 MP4/H.264 + 静音自动播放。所有常青浏览器都能很好地处理，但如果你在本该有动态效果的地方看到的是静态页面：
- 检查浏览器的自动播放策略（Chrome：`chrome://flags/#autoplay-policy`）
- video 元素被设置为 `muted + playsinline`，因此它在任何地方都应能自动播放；如果你的浏览器仍然拦截它，在页面上任意位置点击一次
- 低端设备（老式电视、基础流媒体设备）可能会卡顿 —— 通过 Loadout → Cosmetics 切换到纯 CSS 背景或 “None”

---

## 📡 API 端点

### 面向用户（需要认证）

```
GET    /Plugins/AchievementBadges/users/{userId}                      — full badge list
GET    /Plugins/AchievementBadges/users/{userId}/summary              — unlocked/total/score
GET    /Plugins/AchievementBadges/users/{userId}/rank                 — rank tier + next tier
GET    /Plugins/AchievementBadges/users/{userId}/equipped             — equipped badges
POST   /Plugins/AchievementBadges/users/{userId}/equipped/{badgeId}
DELETE /Plugins/AchievementBadges/users/{userId}/equipped/{badgeId}
GET    /Plugins/AchievementBadges/users/{userId}/recap?period=week|month|year
GET    /Plugins/AchievementBadges/users/{userId}/watch-calendar?days=90
GET    /Plugins/AchievementBadges/users/{userId}/quests               — daily + weekly + reroll state
GET    /Plugins/AchievementBadges/users/{userId}/bank                 — score bank + prestige
POST   /Plugins/AchievementBadges/users/{userId}/prestige
POST   /Plugins/AchievementBadges/users/{userId}/buy-badge/{badgeId}
POST   /Plugins/AchievementBadges/users/{userId}/gift/{toUserId}?amount=N
GET    /Plugins/AchievementBadges/users/{userId}/chase/{badgeId}      — items to watch to finish a badge
GET    /Plugins/AchievementBadges/users/{userId}/recommendations      — top 3 closest-to-unlock
GET    /Plugins/AchievementBadges/users/{userId}/profile-card         — HTML profile card
GET    /Plugins/AchievementBadges/users/{userId}/unlocks-since?since=ISO&deviceId=ID
GET    /Plugins/AchievementBadges/users/{userId}/library-completion
POST   /Plugins/AchievementBadges/users/{userId}/login-ping
GET    /Plugins/AchievementBadges/users/{userId}/directory            (#138) users this user may see, for friend search and compare
GET    /Plugins/AchievementBadges/leaderboard?limit=10
GET    /Plugins/AchievementBadges/leaderboard/{category}?limit=10     — score|movies|episodes|hours|streak|series
GET    /Plugins/AchievementBadges/embedded-page                       — Plugin Pages host fragment
GET    /Plugins/AchievementBadges/server/stats
```

### v2.0 — 道具、商店、外观、任务重抽

```
GET    /Plugins/AchievementBadges/users/{userId}/powerups             — inventory + active state + ScoreBank
POST   /Plugins/AchievementBadges/users/{userId}/powerups/use/{type}  — XpBoost | DoubleCredit (StreakFreeze auto-only)
GET    /Plugins/AchievementBadges/shop/catalog                        — full shop catalog
POST   /Plugins/AchievementBadges/users/{userId}/shop/purchase        — body: {"ItemId":"..."}
GET    /Plugins/AchievementBadges/users/{userId}/cosmetics            — owned + equipped state + LifetimeScore
POST   /Plugins/AchievementBadges/users/{userId}/cosmetics/equip      — body: {"CosmeticId":"..."}
POST   /Plugins/AchievementBadges/users/{userId}/cosmetics/unequip?kind=ProfileTheme|BadgeFrame|RankTitle|Avatar|Background|ProfileBorder
POST   /Plugins/AchievementBadges/users/{userId}/quests/daily/reroll
POST   /Plugins/AchievementBadges/users/{userId}/quests/weekly/reroll
GET    /Plugins/AchievementBadges/asset/{name}                        — animated background mp4s (range-enabled)
```

### 仅限管理员（需要 `RequiresElevation`）

```
POST   /Plugins/AchievementBadges/users/{userId}/backfill
POST   /Plugins/AchievementBadges/backfill-all
POST   /Plugins/AchievementBadges/users/{userId}/reset
POST   /Plugins/AchievementBadges/users/{userId}/reset-badge/{badgeId}
POST   /Plugins/AchievementBadges/users/{userId}/library-completion/recompute
POST   /Plugins/AchievementBadges/users/{userId}/import
GET    /Plugins/AchievementBadges/users/{userId}/export
GET/POST  /Plugins/AchievementBadges/admin/badge-catalog              — enable/disable badges
GET/POST  /Plugins/AchievementBadges/admin/custom-badges              — custom badge definitions
GET/POST  /Plugins/AchievementBadges/admin/challenges                 — seasonal challenges
GET       /Plugins/AchievementBadges/admin/challenge-templates        — one-click templates
GET/POST  /Plugins/AchievementBadges/admin/webhook                    — webhook config (incl. HMAC secret)
GET/POST  /Plugins/AchievementBadges/admin/ui-features                — UI feature toggles
GET       /Plugins/AchievementBadges/admin/audit-log?limit=200
POST      /Plugins/AchievementBadges/admin/users/{userId}/inject-counters
GET/POST  /Plugins/AchievementBadges/admin/feature-config             — feature kill switches + admin controls
DELETE    /Plugins/AchievementBadges/admin/users/{userId}/reset       — wipe user's achievement progress

POST   /Plugins/AchievementBadges/admin/users/{userId}/test/inject-playbacks    — verify integrity caps end-to-end (v1.9.8)
DELETE /Plugins/AchievementBadges/admin/users/{userId}/badges/{badgeId}          — manual badge revoke (v1.9.8)

POST   /Plugins/AchievementBadges/admin/users/{userId}/grant-score              — v2.0 testing
POST   /Plugins/AchievementBadges/admin/users/{userId}/grant-powerup/{type}     — v2.0 testing
POST   /Plugins/AchievementBadges/admin/users/{userId}/grant-cosmetic           — v2.0 testing
POST   /Plugins/AchievementBadges/admin/backfill-milestones                     — v2.0: retroactively unlock title milestones across all profiles
```

---

## 📸 截图

### Xbox 风格解锁弹窗通知
当徽章解锁时，它会在播放过程中弹出。Xbox 圆圈带脉冲光环弹入，扩展为横幅，奖杯旋转（稀有解锁时使用钻石雪碧图），文字上滑，微光扫过，随后整体收起。每种稀有度都有各自的颜色、辉光和音效。

<p align="center">
  <img alt="Xbox-style unlock toast" src="../assets/achievement-animated.gif" />
</p>

> **在线演示：** 下载 [`achievement-combined.html`](../assets/achievement-combined.html)（普通版）或 [`achievement-combined-rare.html`](../assets/achievement-combined-rare.html)（带钻石的稀有版），然后在浏览器中打开。点击任意位置即可启动音效。每 10.5 秒循环一次。

### 独立的成就页面
显示在 Jellyfin 侧边栏中的完整个人资料视图。包含等级进度条、连续天数、积分、完成百分比，以及标签栏（我的徽章、任务、回顾、排行榜、对比、活动、年度总结、统计，还有 v2.0 新增的 **装备** 标签页）。

<p align="center">
  <img alt="Achievements page" src="../assets/screenshots/achievements-page.png" />
</p>

### 徽章网格
35+ 个类别中的 200+ 枚徽章，每枚都带有实时进度条和「装备」按钮。已解锁的徽章以彩色显示并带有绿色状态标记；已锁定的徽章变暗。按稀有度着色的边框让你能够直观地扫视整个网格。

<p align="center">
  <img alt="Badge grid overview" src="../assets/screenshots/badges-overview.png" />
</p>

### 实际效果中的稀有度层级
类型专精徽章与连续纪录的极端徽章，覆盖全部六种稀有度颜色——普通、罕见、稀有、史诗、传说、神话。

<p align="center">
  <img alt="Genre + rarity badges" src="../assets/screenshots/genre-badges.png" />
</p>

### 每日与每周任务
从模板池中轮换的任务。服务器上的所有人都会获得相同的每日 + 每周挑战，因此大家可以互相竞赛。完成任务会为积分银行充值。在 v2.0 中，每个分区标题都有一个重抽按钮。

<p align="center">
  <img alt="Daily and weekly quests" src="../assets/screenshots/quests.png" />
</p>

### 回顾
按周、月、年拆解你实际观看的内容——总条目数、活跃天数、热门类型、热门导演和热门演员。

<p align="center">
  <img alt="Recap view" src="../assets/screenshots/recap.png" />
</p>

### 年度总结
Spotify 风格的年度回顾，带有大幅渐变主视觉、「你的数字」（电影、剧集、活跃天数、最佳连续、总时长）、「你的亮点」（最活跃的一天、最活跃的月份、观看最多的星期）以及「你的最爱」（热门类型/导演/演员）。

<p align="center">
  <img alt="Year Wrapped view" src="../assets/screenshots/wrapped.png" />
</p>

### 排行榜
前三名的领奖台视图，下方是排名列表。通过标签行切换类别：积分、电影、单集、时长、最佳连续、剧集。（用户名已模糊为 User 1–10。）

<p align="center">
  <img alt="Leaderboard view" src="../assets/screenshots/leaderboard.png" />
</p>

### 对比个人资料
服务器上任意两位用户之间的正面个人资料对比。渐变条显示 12 项核心指标的相对数值，底部的胶囊标签拆解出每个用户拥有的、对方没有的徽章数量。（用户名已模糊为 User 1 / User 2。）

<p align="center">
  <img alt="Compare profiles view" src="../assets/screenshots/compare-profiles.png" />
</p>

### 连续日历
GitHub 风格的全年观看活动日历。当前连续、历史最佳和总活跃天数一目了然。

<p align="center">
  <img alt="Streak calendar" src="../assets/screenshots/streak-calendar.png" />
</p>

### 观看热力图
90 天热力图网格，按每日观看量着色。点击范围按钮可在 30/90/180/365 天之间切换。

<p align="center">
  <img alt="Watch heatmap" src="../assets/screenshots/watch-heatmap.png" />
</p>

### 类型雷达 + 观看时钟
展示你前 5 类型分布的 SVG 蜘蛛图，以及呈现你实际观看时段的 24 小时极坐标图。

<p align="center">
  <img alt="Genre radar + watch clock" src="../assets/screenshots/genre-radar.png" />
</p>

### 管理面板
每个管理员区块都可折叠，让页面保持整洁：webhook 通知、弹窗通知预览、UI 功能开关、可视化徽章编辑器、挑战模板、审计日志、进度注入、自定义徽章、赛季挑战、逐徽章启用/禁用，以及 v2.0 测试工具（发放积分 / 道具 / 外观，回填里程碑）。

<p align="center">
  <img alt="Admin panel" src="../assets/screenshots/admin-panel.png" />
</p>

### 高级选项
扫描观看历史、重置徽章、扫描所有用户，或加载指定的用户 ID——全部都在「高级选项」开关下的一行中。

<p align="center">
  <img alt="Advanced options" src="../assets/screenshots/advanced-options.png" />
</p>

### 侧边栏入口
自动注入到 Jellyfin 导航菜单中——无需修改主题。

<p align="center">
  <img alt="Sidebar entry" src="../assets/screenshots/sidebar-entry.png" />
</p>

---

## 📜 发布历史

每个版本的完整说明和已签名的二进制文件都在 GitHub Releases 页面上：

➡ **[github.com/ZL154/AchievementBadges_for_Jellyfin/releases](https://github.com/ZL154/AchievementBadges_for_Jellyfin/releases)**

重点内容：

- **v2.4.2** — 按你实际观看内容计数的类型与制片公司徽章：剧集会为制片公司徽章计入成绩，TMDb 复合类型（“Action & Adventure”）对每个组成部分分别计入，制片公司别名和整词名称（“Walt Disney Pictures”、“HBO Max”）计入其所属制片公司，每个条目每个徽章只计一次（#154，@mattsigal，他的第一个 PR，与 @camarigor 合作）；好友聊天的消息框在手机上保持位于导航栏之上（#147）；插件卡片图片不再被目录裁剪（#146）
- **v2.4.1** — 修正 2.4.0 的错误，并提供一个可以调高的上限：Jellyfin 12 安装包现在会报告它实际发布的版本号，因此卸载和插件图片都能正常工作（#140）；在安装之前就缓存了 Jellyfin 页面的浏览器会拿到插件而不是过期副本（#141）；**定向徽章上限**可设置为 1000，并会指出超出的部分（#129）；Revamp 样式不再重绘 Jellyfin 自身的控件（#133）；在替换页面的主题下，自定义标签页重新可以渲染（#131）；**顶部居中弹窗通知**以及服务器默认值，且默认 UI 样式真正能够持久保存（#136/#43）；对登录界面隐藏的账号可以排除在其他用户的视图之外（#138）；以及一个自 2.1.0 起就一直**让整个服务器的 OpenAPI 文档返回 500** 的类型名冲突已经消失
- **v2.4.0** — Jellyfin 12、定向徽章、游戏：每次发布提供两个安装包（`x.y.z.0` 用于 10.11，`x.y.z.1` 用于 12），入口位于 12 的头像菜单中，并带上 12 要求的 `Authorization` 请求头（#109/#117/#122）；`ContainerCompletionPercent` + `ItemPlayCount` 以及媒体库选择器（#107/#108）；JellyEmu 游戏成就（#115/#120）；所有商店外观都显示在可分享卡片和抽屉卡片上（#42/#119）；Revamp 下的弹窗通知位置（#116/#118）；Pastel 页面泄漏、不可见的边框/框架、过期的样式表令牌、#97 诊断
- **v2.3.1** — 音乐修复 + 排行榜：曲目不再继承专辑/艺术家的类型，因此自定义音乐徽章可以正确计数（#94），扫描会重放已播放的音乐，因此作品集徽章可以重建（#96），两个排行榜都会显示你自己的等级，已删除的账号被排除且可清理，Blades 皮肤更名为 Aurora
- **v2.3.0** — 好友与基础能力：悬停/点击好友资料卡片（#76），由受隐私保护的摘要端点支撑；三种可分享卡片皮肤（Console / Metro / Aurora Spine），由每位用户自行选择；媒体库完成度现在在扫描期间计算（#80），并新增艺术家作品集完成度（#81、#24）；Tracearr 历史记录计入（#77/#84/#85）；观看时长跨重启和文件替换保留（#87/#89/#91/#92）；管理员设置默认 UI 样式 + 锁定（#43）；以及针对已发布构建的资料数据丢失（#59/#60）和 gzip 注入（#46）修复
- **v2.2.0** — 你的界面，你做主：可选的 Custom Tabs + Plugin Pages 宿主，以及独立的按用户导航控制（#37）；分组/单条与全设备/来源设备的解锁通知模式（#38）；可点击、可用键盘访问的真实解锁弹窗；管理员 10 条弹窗分组预览；按构建区分的客户端缓存键；完整的 8 种语言覆盖
- **v2.1.3** — 开放媒体库补丁：按类型的音乐徽章，因此类型筛选器真正生效（#24）；自定义徽章可完全删除 + 清除已获得的副本 + 保留 ID 的迁移（#24）；头部 UI 在其他注入头部的插件存在时仍能存活（#36）；徽章分类标签修复；徽章/任务构建器在全部 8 种语言中的完整本地化
- **v2.1.0** — 开放媒体库：音乐 + 图书成就、自定义徽章构建器（复合 AND/OR）、JS Injector 回退方案（#26）、通过 Genres+Tags+Series 进行动漫检测（#25）、每日徽章回填修复 + 审计/清理工具（#27）、地球图标语言选择器 + 完整的管理员页面本地化
- **v2.0.0** — 选择你的装备：道具、积分商店、70+ 种外观、8 种视频背景、完整国际化
- **v1.9.8** — 诚信版本：封堵播放计分漏洞（标记为已播放、快进到结尾、疯狂点击都不再计入），真实观看计分门槛（累计播放时间片 ≥80%，且排除快进部分），最短时长 60 秒过滤，每日计分上限，可疑速率审计标记，手动撤销徽章
- **v1.9.7** — 仅安全更新：按用户的聊天附件配额、资料卡 CSP 收紧、SVG 清理器新增 SMIL 拦截、Webhook DNS 超时
- **v1.9.6** — 弹窗通知描述修复、播放弹窗默认开启、管理员/配置页面上的服务器用户选择器
- **v1.9.5** — 聊天附件修复、安全加固
- **v1.9.4** — 32 个新徽章（下午、黄金时段、节日扩展、动漫层级、制片公司专家、试播集与完结者）+ 8 种语言的手工定制翻译
- **v1.9.0** — Revamp UI（Classic/Revamp 切换）、好友抽屉 Revamp、“离线 — 最后观看”、HMAC Webhook 签名、安全升级（速率限制、CSP、审计日志过滤器、GitHub Actions CI）
- **v1.8** — 完整私信套件（1:1 + 群组、附件、已读回执、编辑/删除、拉黑、通知）
- **v1.7** — 好友抽屉基础功能，法语由 [@frenchyx24](https://github.com/frenchyx24) 手工翻译

---

## 🗂️ 往期发布说明

更早版本的完整说明，最新的在前。

## 🚀 v2.4.1 新特性 — 修正 2.4.0 的错误，并提供一个可以调高的上限

针对 2.4.0 报告的全部问题，包括两个让正确安装看起来像是在 Jellyfin 12 上坏掉的故障，以及一个对于成百上千地编写定向徽章的人来说现在可以调高的上限。**可从 v2.4.0 直接升级 — 无架构变更，无需迁移。** 完整说明见 [docs/release-notes/v2.4.1.md](release-notes/v2.4.1.md)。

### 🟣 两个 Jellyfin 12 故障（#140、#141）

- **卸载完全失败，插件图片返回 404。** 每次发布都从同一个源代码树构建两个安装包，而两个程序集都被标记为 `x.y.z.0`。于是 Jellyfin 对同一次安装读到了两个不同的版本号 — 仪表盘显示的是程序集的版本号，而卸载和图片端点则通过清单中的版本号解析 — 因此在 Jellyfin 12 上，插件以 `2.4.0.1` 安装、显示为 `2.4.0.0`，并且无法删除。现在每个安装包都会标记它所发布的版本号。**卡在 2.4.0.1？** 通过目录更新即可；加载新构建时的那次重启会删除旧文件夹。
- **页面只在隐私窗口中能用，其他地方都不行。** 在插件安装*之前*就缓存了 Jellyfin 页面的浏览器会重新校验该页面，Jellyfin 从磁盘上的文件返回 `304 Not Modified`，于是没有可供插件注入的页面正文 — 浏览器便永远继续使用那份不含插件的副本。在 Web 目录为只读的服务器上问题最严重，那里磁盘补丁也永远无法生效。现在只要磁盘补丁尚未生效，中间件就会强制返回完整页面。**没有人需要清除浏览数据** — 更新后正常刷新一次就够了。

### 🎯 一个可以调高的定向徽章上限（#129）

- **上限现在是一个设置项**，位于*自定义徽章* → **定向徽章上限**（1 到 1000，默认值仍为 50）。页面会显示你已启用的徽章引用了多少个不同的目标、以及该上限是多少，并**列出超出上限的目标**，让你看到哪些没有被计算。
- **每次播放的检查不再随目标数量增长。** 剧集、季和文件夹通过一次查找与已播放条目的祖先进行比对；合集和播放列表使用按目标缓存的成员列表，并在容器变化时刷新。在任何服务器上，数百个目标都没有问题。

### 🎨 针对 2.4.0 报告的修复

- **Revamp 样式影响到了 Jellyfin 的其他部分（#133）。** 在选择 **UI：Revamp** 后，插件会重绘 Jellyfin 自身的控件以及所有其他插件的设置页面 — 复选框变得不可见，文本输入框丢失边框和高度，文本选中颜色到处都被改变。有十二条规则只依据 `<body>` 上的某个属性，却命名了通用元素；现在它们被限定在插件自己的两个界面上，并且有测试会拒绝任何这种形态的新规则。
- **渲染不出任何内容的自定义标签页（#131）。** 对于自带 Jellyfin 首页副本的主题（Abyss 的 Spotlight），Custom Tabs 的服务端面板注入会静默匹配失败，导致标签页按钮背后没有面板 — 成就页面一片空白。现在插件会自行构建缺失的面板。
- **弹窗通知新增顶部居中位置，以及服务器默认值（#136）。** 顶部居中加入了现有的五个位置，管理员可以为所有尚未选择的人设置默认值；用户自己的选择仍然优先。在这之下还暴露出两个 bug：**#43 中的默认 UI 样式其实从未被存储**，以及**每次保存主配置都会静默地把页面集成重新关闭**。
- **对登录界面隐藏的账号可以排除在其他用户的视图之外（#138）。** 默认关闭。开启后，带有 Jellyfin 的*在登录界面隐藏此用户*的账号只对自身、管理员、其他隐藏账号以及已与其互为好友的账号可见。请注意，Jellyfin 会为它创建的账号勾选该复选框，因此在保持默认设置的服务器上，每个账号都是隐藏的，该选项不会带来任何改变。

### 📄 插件当时正在破坏你服务器的 API 文档

在测试本版本时发现，无人报告过，并且自 **2.1.0** 起在 Jellyfin 10.11 和 12 上都存在：`GET /api-docs/openapi.json` 会对**整个服务器**返回 **500**。

Jellyfin 会把自身和每个已安装插件的 OpenAPI 文档合并成一份，其中的每个 schema 都以裸类型名作为键。本插件的媒体类型枚举名为 `MediaType`，而这也是 Jellyfin 自身某个枚举的名称 — 重名不会被解决，而是会抛出异常，把整份文档拖垮。Swagger UI、仪表盘的 API 浏览器以及所有读取该规范的生成器全都失效了，而这一切出自一个能干净启动、对此毫无日志输出的插件。

该枚举现在名为 `BadgeMediaType`。它的数值和承载它的属性都没有变化，因此**无需迁移任何内容**。冲突消除后文档可以正常构建，本插件的 126 条路由首次出现在其中。现在有一项测试会把插件的公开类型与 Jellyfin 的公开类型逐一比对，只要出现同名就会失败，因为除此之外没有别的办法能发现这个问题：故障出在宿主的文档里，而不是本插件的文档里。

> 如果更新后你的 API 文档页面仍然无法使用，那说明另一个插件也以同样的方式发生了冲突 — 服务器日志会列出这两个类型名。

衷心感谢 **[@camarigor](https://github.com/camarigor)** 贡献了上限与每次播放的重构（#130）、Custom Tabs 修复（#132）、Revamp 作用域限定（#134）、弹窗通知工作（#137）、隐藏账号选项（#139），并发现了 #140/#141 首轮修复中的错误（#144）；感谢 **[@Roboatlas21](https://github.com/Roboatlas21)** 根据他的日志诊断出两个 Jellyfin 12 故障（#140、#141）；感谢 **[@Tschiyo](https://github.com/Tschiyo)** 提出上限需求（#129）；感谢 **[@Borededdy](https://github.com/Borededdy)** 报告空白自定义标签页（#131）；感谢 **[@clarjon1](https://github.com/clarjon1)** 报告 Revamp 泄漏（#133）；感谢 **[@Verdancy-Rin](https://github.com/Verdancy-Rin)** 提出顶部居中位置（#136）；感谢 **[@Digital-Yeti](https://github.com/Digital-Yeti)** 提出隐藏账号需求（#138）。

---

## 🚀 v2.4.0 新特性 — Jellyfin 12、定向徽章、游戏

Achievement Badges 可以在 Jellyfin 12 上运行，获得了首批能指向你媒体库中某个具体条目的徽章，学会了对游戏计数，还终于能把你从商店买来的行头展示给其他人。**可从 v2.3.x 直接升级 — 无架构破坏，无需手动迁移。** 完整说明见 [docs/release-notes/v2.4.0.md](release-notes/v2.4.0.md)。

### 🟣 Jellyfin 12（#109、#117、#122）

- **每次发布提供两个安装包。** `x.y.z.0` 是 Jellyfin 10.11 构建（.NET 9），`x.y.z.1` 是 Jellyfin 12 构建（.NET 10）。插件目录会为你的服务器选择正确的那个；把服务器从 10.11 升级到 12 之后，会以插件更新的形式提供 `.1` 构建。
- **成就入口移到了头像菜单。** Jellyfin 12 的现代布局隐藏了旧的抽屉和头部，因此该入口现在位于头像菜单中**个人资料**的正下方，已装备徽章条则位于头像旁边的工具栏中。旧版布局（desktop-legacy、mobile-legacy、TV）仍保留抽屉入口。
- **每次调用都会发送 12 要求的 `Authorization` 请求头。** Jellyfin 12 关闭了旧版授权，因此仅凭旧的 `X-Emby-Token` 会得到 401 — 这让此前每个版本在 12 服务器上的页面都无法使用。现在两个请求头都会发送；10.11 接受其中任意一个。
- Revamp 管理员页面适配 MUI 仪表盘，链接使用 `#/` 路由，并且页面打开时标签页名为*成就*。

### 🎯 定向徽章（#107）

- 两个新指标让徽章可以指向**一个**具体条目：`ContainerCompletionPercent`（某个剧集、季、合集、播放列表或专辑中已播放条目占总数的比例 — 100 表示你已看完）和 `ItemPlayCount`（Jellyfin 自身对单部电影、单集或单曲的播放次数 — 1 表示“看过”，3005 则是 Childish Gambino 徽章）。
- 管理员页面中的**媒体库选择器**可按名称查找目标；存储的引用会同时保留 id 和名称，因此徽章在重命名以及删除后重新添加的情况下都能存续。
- **创建时即追溯生效** — 任何已经完成该目标的人都会立即解锁，无需扫描 — 而且它依据 Jellyfin 的已播放标记，因此手动把某一季标记为已观看也会计入。
- 任意分组（“One Piece: Alabasta”）通过 Jellyfin 合集实现。参见[定向徽章](#定向徽章)。

### 🎮 游戏成就（#115）

- 通过 **JellyEmu** 玩的游戏现在可以获得成就。JellyEmu 会把每个会话作为播放会话上报给 Jellyfin；插件现在按它们自身的方式度量这些会话（会话时长，设有下限和上限，均可配置），而不是把它们当作没有时长的电子书丢弃。
- **九个内置徽章**，位于新的游戏分类下（会话数、不同游戏数、小时数、平台），以及**三个自定义徽章指标**（某平台上的不同游戏数、某开发商的不同游戏数、通过选择器指定的某一款游戏的时长）。参见[游戏成就](#游戏成就jellyemu)。

### 🪪 你装备的一切都会显示在卡片上（#42）

- 你的**自定义头衔、徽章边框、资料主题、资料边框、动态背景和头像**现在都会显示在可分享的资料卡上（全部三种皮肤），以及当有人在好友抽屉中点击你的名字时打开的卡片上 — 与已装备徽章受同样的隐私开关控制。动态背景会在卡片背后播放真实的视频循环。
- 顺带修复了两个在成就页面本身上从未生效的问题：资料**边框**在 Revamp 样式下从不显示，徽章**边框**也只应用于某个标签页的某一行 — 现在它们会环绕展示药丸、头部条和抽屉展示区。
- **“Pastel 存在未隐藏的元素”**（TsunamicFlame 在 #42 中的报告）确有其事：每个渐变主题都会让 Jellyfin 自己的页面从成就页面顶部透出来。已为全部 14 个主题修复。

### 🩺 针对 #97 的诊断

- 管理员页面的错误现在会**指明失败的是哪个请求**（`Request failed: 400 (GET users/…/summary)`），并且加载失败不再被报告为重置或扫描失败。
- **重置**对格式错误的 id 返回 400，对 Jellyfin 不认识的账号返回 404，而不是对任何情况都返回 200。
- **什么都没有找到的观看历史扫描**会明确说明，并指向该账号的媒体库访问权限，且支持全部 8 种语言。

### 🧱 修复

- 弹窗通知位置在 Revamp 下从未生效 — 五种位置全都渲染在右上角（#116，@camarigor）。
- Revamp 样式表在三处都以过期的令牌缓存，导致样式表变更可能延迟一天才到达浏览器。
- 登录页面会触发约 25 个 `Users/Me` 请求；管理员页首图永远显示“v1.9.2 / ABI 10.11.0.0”；商店的“达到 N 积分自动解锁”药丸被裁剪。

衷心感谢 **[@camarigor](https://github.com/camarigor)** 贡献了 Jellyfin 12 构建与 Web 客户端工作（#117、#122）、定向徽章（#108）、游戏成就（#120）、卡片上的商店外观（#119）、弹窗通知修复（#118）以及依赖轮次（#128）；感谢 **[@Lyxon1337](https://github.com/Lyxon1337)** 报告 Jellyfin 12；感谢 **[@unknownTGG](https://github.com/unknownTGG)** 提出定向徽章需求；感谢 **[@TsunamicFlame](https://github.com/TsunamicFlame)** 贡献 #42、#115、#116 以及其背后的实地测试。

---

---

## 🚀 v2.3.1 新特性

2.3.0 的快速跟进版本，修复了它发布的音乐功能并整理排行榜。**可从 v2.3.0 / v2.2.x 直接升级 — 无架构破坏。**

- **音乐真正开始计数（#93/#94、#95/#96）。** 曲目不再从其专辑或艺术家继承类型和标签，因此“播放 50 首迪斯科曲目”徽章不会再计入舞曲和流行乐的播放。而且观看历史扫描现在会重放已播放的音乐，因此 2.3.0 中的艺术家作品集徽章可以重建，而不只是从实时播放中构建。感谢 [@Daemon-Network](https://github.com/Daemon-Network) 在发布后一天内发现了这两个问题。
- **查看你自己的等级。** 管理员端和面向用户的排行榜现在始终显示你的位置 — 如果你进入前十则高亮显示，如果等级更低则附加你的真实等级（适用于独立页面上的全部六个分类榜单）。
- **已删除账号得到清理。** 它们不再以原始 GUID 的形式出现在排行榜上，也不会虚增用户数；管理员端的统计和排行榜标签页在打开时刷新；新增的**清理已删除账号**管理员按钮可以回收它们的存储空间。
- **Blades** 可分享卡片皮肤现在更名为 **Aurora**，以配合其重新设计，并已在全部八种语言中本地化。

---

## 🚀 v2.3.0 新特性 — 好友与基础能力

Achievement Badges 增加了社交层 — 查看好友的近况，并分享你自己的卡片 — 同时带来一系列可靠性修复，其中几项对使用已发布 v2.2.0 构建的人都很重要。**可从 v2.2.x / v2.1.x / v2.0.x 直接升级 — 无架构破坏，无需手动迁移。**

### 👋 好友资料卡片（#76）

在抽屉中悬停好友的名字或头像即可看到摘要卡片 — 等级层级、完成度、积分、最佳连续和已装备的展示。点击可固定一张更大的卡片，指针离开后仍然保留，按 Escape 或点击外部会关闭，并且可以通过键盘访问。它由公开摘要端点支撑，该端点受隐私限制，不会暴露排行榜之外的任何内容：任何选择不列入榜单的人在这里同样不可见。

### 🪪 可分享卡片皮肤

三种由服务器渲染的资料卡皮肤 — **Console**（默认）、**Metro** 和 **Aurora Spine** — 每种都以卡片拥有者自己的等级颜色作为唯一强调色。每位用户都可以在偏好设置中选择自己的皮肤；在没有指定样式的情况下打开的卡片会回退到拥有者的选择。

### 🎯 终于能正常运行的完成度追踪

- **媒体库完成度（#80、#79）。** 五个媒体库完成度徽章现在在观看历史扫描期间计算，因此它们可以通过正常使用解锁，而不是在每个安装上都一直是零。
- **艺术家作品集完成度（#81、#24）。** 每位艺术家的已播放曲目数除以总曲目数 — 一个用于完成任意艺术家的徽章，以及一个针对特定艺术家的参数化指标。

### 📡 Tracearr 历史记录计入（#77 / #84 / #85）

通过 Tracearr 的公开 v2 API，计入媒体库扫描自身无法证实的真实首次观看 — 你已删除的媒体，以及真实的重看次数。独立的同步按钮由账本保证幂等，因此第二次按下不会再计入任何内容。在管理员端使用 URL 和令牌进行配置；Tracearr 端不需要任何操作。参见 [Tracearr 集成](#-tracearr-集成)。

### 🔔 通知与布局

- **按用户的弹窗通知位置**：四个角中的任意一个、顶部居中或底部居中，实时生效，并可由管理员为所有尚未选择的人设置服务器默认值（#136）。
- 解锁弹窗通知移出了字幕行，并且当视频播放器显示在屏幕上时，浮动的好友按钮会隐藏。
- **管理员设置默认 UI 样式，并可选锁定（#43）** — 让用户以 Classic 或 Revamp 开始，并可选地将其设为唯一选择，使页面与你的 Jellyfin 主题匹配；用户自己的选择会被记住，并在解除锁定时恢复。

### 🧱 可靠性

- **观看时长结转**可以在会话中断、重启以及媒体文件替换或画质升级后存续（以媒体标识为键，#89），并具有可配置的保留窗口（#87）。扫描会清除它所计入部分的结转（#91/#92），因此之后的局部重看无法仅凭已计入的分钟数达到完成门槛。
- **计数器韧性** — 重建的计数器设有下限，并保留带日期的快照，因此扫描永远不会丢失进度；积分库在重建时设有下限，因此已删除的媒体不会把余额清零；回填按用户串行执行；加载失败会显露出来，而不是被渲染成空或加载中。

### 🩹 针对所有使用 v2.2.0 的人的修复

- **空的孪生资料可能会吞掉已解锁的徽章（#59/#60）。** `GetOrCreateProfile` 现在会先规范化用户 id，因此好友和私信路径无法在活动资料旁边创建一个空资料，后者之后会覆盖前者。仅仅打开好友面板就足以触发它。
- **在 gzip 下注入的 UI 从未挂载（#46）。** 客户端引导程序现在会注入到压缩响应中，而不是跳过它们 — 每个浏览器都会请求 gzip，因此在 v2.2.0 上侧边栏、小组件、条目绶带和弹窗通知都静默加载失败。这也是 #37 和 #36 报告背后的原因。

### 🌍 本地化

每个新的界面字符串都已在全部 8 种 UI 语言中翻译，并且管理员用户选择器字符串已在七种非英语语言环境中补全，实现了完整的键一致性。

衷心感谢 **[@camarigor](https://github.com/camarigor)** 贡献了好友资料、Tracearr 集成、媒体库与艺术家完成度接线、观看时长结转工作，以及资料数据丢失 + gzip 注入修复。

---

## 🚀 v2.2.0 新特性 — 你的界面，你做主

本版本让 Achievement Badges 适配每位用户的 Jellyfin 布局和通知偏好，同时始终保留原版成就页面可用。**可从 v2.1.x / v2.0.x 直接升级 — 无架构破坏，无需手动迁移。**

- **可选的 Custom Tabs 和 Plugin Pages 宿主（#37）。** 管理员可以独立选择启用其中任一集成。两者都复用同一个成就界面，而不是维护重复的页面，并且兼容性失败会被隔离，因此不会阻止 Jellyfin 启动。
- **按用户的导航控制（#37）。** 每位用户都可以在成就设置或 Jellyfin 原生用户设置中独立显示或隐藏 Custom Tabs 入口、Plugin Pages 入口和头部奖杯。隐藏导航绝不会禁用追踪、通知或原版页面。
- **分组或单条的解锁连发（#38）。** 同时发生的解锁可以合并为一条带合计积分的摘要，也可以使用现有的队列一条一条播放。
- **按设备范围的解锁通知（#38）。** 用户可以保持默认：投递到每个已登录客户端，也可以把弹窗通知限制在获得该成就的 Jellyfin 设备上。服务器会验证来源设备，而不是仅信任浏览器。
- **解锁弹窗现在会通向有用的地方。** 点击一条真实的单条解锁（或聚焦它并按 Enter/空格）会打开我的徽章、清除筛选、滚动到确切的徽章并短暂高亮它。分组摘要会打开最近解锁。管理员合成预览则有意保持不可导航，且绝不会写入成就数据。
- **更好的通知测试。** 新的**测试 10 条解锁**管理员控件会演练已保存的分组偏好，而不会创建解锁或修改资料。
- **每次构建都使用全新的客户端资源。** 脚本缓存键现在包含编译后的模块 ID，防止浏览器在测试或部署期间保留同版本的旧 UI。
- **完整本地化。** 每个新选项、帮助信息、导航标签和弹窗通知操作都已在全部 8 种 UI 语言（英语、法语、西班牙语、德语、意大利语、葡萄牙语、中文、日语）中翻译。

---

## 🚀 v2.1.3 新特性

一个修复 #24 和 #36 中未解决问题的小补丁，以及一次完整的构建器本地化。**可从 v2.1.x / v2.0.x 直接升级 — 无架构破坏；会自动运行一次保留 ID 的自定义徽章迁移。**

- **按类型筛选的音乐徽章现在真正按类型筛选（#24）。** 音乐播放次数和收听时长现在**按类型**追踪（不区分大小写），因此当你听金属乐时，“播放 50 首迪斯科曲目”徽章不再增长。三个新的构建器指标 — *某类型的音乐播放次数*、*某类型的音乐时长*、*某类型的已观看条目数* — 在被选中时会显示一个类型字段。
- **自定义徽章可以完全删除（#24）。** 可视化构建器、徽章列表和删除现在共用同一个存储（此前它们是分开的，因此构建器创建的徽章无法删除），删除某个徽章会从每个用户资料中清除其已获得 + 已装备的副本。已存在的徽章会在首次启动时迁移，并保留其 ID。
- **头部 UI 在其他注入头部的插件存在时仍能存活（#36）。** 当第二个插件（例如 Ratings）从 `index.html` 中剥离了徽章脚本时，插件过去会以为自己仍处于已打补丁状态，因而从不重新注入。现在守卫依据实际的 script 标签，因此被剥离的页面总会被修复。
- **徽章分类标签已修复（#24）。** 像 *Studio Specialist* 和 *Books* 这样的分类不再显示为原始的 `category.*` 键，并且每个内置分类现在都已翻译。
- **完整的构建器本地化。** 徽章构建器指标列表、任务构建器、道具 + 外观选择器以及状态消息现在已在全部 8 种语言（en/fr/es/de/it/pt/zh/ja）中翻译。

---

## 🚀 v2.1.0 新特性 — 开放媒体库

成就扩展到电影和电视之外，管理员也获得了真正的徽章编写能力。**可从 v2.0.x 直接升级 — 无架构破坏，无需数据迁移。**

### 🎵 音乐成就

**18 个内置音乐徽章**由真实收听驱动 — 总播放次数、收听时长，以及不重复的**专辑 / 艺术家 / 类型 / 年代**。音频条目现在与电影和剧集一样，流经同一条播放计分流水线（80% 真实收听门槛）。

### 📚 图书成就

**8 个图书徽章** — 已完成的图书、有声书收听时长，以及已完成的图书系列。**有声书计数策略**让管理员选择有声书的播放是仅计入图书（默认）、仅计入音乐，还是两者都计入。

> **如何检测电子书完成（重要）：** Jellyfin 没有“读完电子书”的信号 — 与有声书和音乐不同（它们通过会话流式播放并自动追踪收听时长），电子书是没有时长的文本。因此**电子书在被标记为_已播放_后才计入**（条目上的 ✓ /“标记为已观看”开关）。仅仅在 Jellyfin 阅读器中翻到最后一页**不会**自动标记它，因此在图书被标记为已播放之前，图书徽章不会变化。这是 Jellyfin 的限制，插件无法自行检测。

### 🛠️ 自定义徽章构建器

使用跨任意指标的**复合 AND/OR 条件**定义你自己的徽章 — 电影、电视、音乐、图书等等。简单徽章通过管理员表单创建；复合条件、图标以及导入/导出通过 API 完成。完整指南 + 可直接复制的模板：[自定义徽章](#-自定义徽章)。

### 🌐 JS Injector 回退方案（问题 #26）

在 `/usr/share/jellyfin/web` 不可写的裸机 Linux 上，磁盘上的 UI 注入过去会静默失败。插件现在会检测 [JavaScript Injector 插件](https://github.com/n00bcodr/Jellyfin-JavaScript-Injector)，并给出要粘贴的确切脚本 URL。详情：[故障排查](#-故障排查)。

### 🇯🇵 动漫检测修复（问题 #25）

现在会从 **Genres *和* Tags** 检测动漫，同时读取条目**及其父剧集**，并可通过管理员配置媒体库 / 类型 / 标签 — 修复了当分类位于剧集或标签上时动漫徽章从不触发的问题。

### 🗓️ 每日徽章回填修复 + 审计工具（问题 #27）

按时间窗口的徽章（每日 / 每周 / 每月）现在会在**初始历史扫描期间被跳过**，因此它们不再因累计总量而被错误解锁。新的管理员**审计 + 清理工具**会找出并清除 v2.1.0 之前的回填错误授予的徽章（之后可以自然地重新获得）。

### 🌍 地球图标语言选择器 + 完整管理员本地化

管理员页面上的**地球下拉菜单**可以实时切换 UI 语言，并在刷新后保持；**整个管理员页面** — 包括诚信和测试工具部分 — 现在都已在全部 **8 种语言**中本地化。

---

## ❤ 支持本项目

Achievement Badges 是我在业余时间开发和维护的。如果它对你有用，并且你愿意支持持续开发，以下任何一种方式都意义重大：

- ⭐ **给本仓库点 Star** — 这是免费的，并且能帮助其他人找到它
- 💖 **[在 GitHub 上赞助](https://github.com/sponsors/ZL154)** — 一次性或按月，每一美元都会用于本项目
- ☕ **[在 Ko-fi 上请我喝杯咖啡](https://ko-fi.com/zl154)** — 一次性打赏

并不强求，只是心存感激。贡献 — 问题反馈、PR、翻译修正 — 同样宝贵。

---

## 🙏 致谢与鸣谢

- **[@frenchyx24](https://github.com/frenchyx24)** — **全部 171 个内置徽章的完整法语翻译**（手工翻译的标题 + 描述，在 v1.7.2 中从 [issue #5](https://github.com/ZL154/AchievementBadges_for_Jellyfin/issues/5) 合并）。他还提交了最初的多语言功能请求，以及塑造了 v1.6.1 → v1.7.x 的停用已装备徽章 / 任务自定义 / Xbox 徽标 bug 报告。Merci beaucoup !
- **[@camarigor](https://github.com/camarigor)** — 在 v2.4.2 中对 @mattsigal 的类型和制片公司修复（#154）的评审与每条目只计一次的计数、适配手机的好友抽屉（#149）以及新的插件卡片美术（#148）；在 v2.4.1 中贡献了定向徽章上限与每次播放的重构（#130）、Custom Tabs 面板修复（#132）、Revamp 样式作用域限定（#134）、带服务器默认值的顶部居中弹窗通知（#137）、隐藏账号选项（#139）以及对 #140/#141 修复的更正（#144）；v2.4.0 的 Jellyfin 12 构建与 Web 客户端重构（#117/#122）、定向徽章（#108）、JellyEmu 游戏成就（#120）、可分享卡片上的商店外观（#119）以及弹窗通知位置修复（#118）；在此之前还有 v2.3.0 的好友资料卡片与公开摘要端点（#76）、Tracearr 历史记录集成（#77/#84/#85）、媒体库 + 艺术家完成度接线（#80/#81）、观看时长结转的可靠性工作（#87/#89/#91/#92）、v2.3.1 中的音乐修复（#94/#96），以及资料数据丢失（#59/#60）和 gzip 注入（#46）修复。
- **[@mattsigal](https://github.com/mattsigal)** — v2.4.2 中的类型和制片公司徽章修复（#154）：电视剧集会为其所属剧集的制片公司计入、TMDb 复合类型，以及制片公司名称别名，在真实服务器上，这让人们早已获得的类型徽章得以解锁。他在这里的第一个 PR。
- **[@Roboatlas21](https://github.com/Roboatlas21)** — 根据他自己的日志诊断出 v2.4.1 中修复的两个 Jellyfin 12 故障（#140、#141），并报告了 v2.4.2 中修复的插件卡片被裁剪（#146）和手机聊天框（#147）问题。
- **[@Daemon-Network](https://github.com/Daemon-Network)** — 最初的音乐与图书需求（#24），以及对 2.3.0 的详尽真实音乐媒体库测试，正是这次测试暴露了 v2.3.1 中修复的三个音乐 bug。
- **[@TsunamicFlame](https://github.com/TsunamicFlame)** — Custom Tabs / Plugin Pages 需求（#37）、好友资料卡片与卡片上商店外观的需求（#42）、JellyEmu 游戏成就需求（#115）、弹窗通知位置报告（#116），以及所有这些背后的实地测试。
- **[@unknownTGG](https://github.com/unknownTGG)** — 促成 `ContainerCompletionPercent` 和 `ItemPlayCount` 的定向徽章需求（#107）。
- **[@Lyxon1337](https://github.com/Lyxon1337)** — Jellyfin 12 报告（#109）。
- **xdnewlun1（Techno Cricket, CCDC）** — 在 v1.6.0 中负责任地披露了 12 项安全问题，包括导致 `UserOwnershipFilter` 诞生的严重 IDOR。
- **Uenify** — Xbox 风格的弹窗通知动画（圆形放大、横幅扫过、微光、文字滑入）是他 [CodePen](https://codepen.io/uenify) 到原生 JS + 按稀有度配色方案的移植。
- es / de / it / pt / zh-CN / ja 的翻译始于一轮自动化处理 — 欢迎母语者通过 PR 打磨。

---

## 📜 许可证

本项目在 [MIT License](../LICENSE) 下发布 — 它是常用开源许可证中最宽松的之一。

**摘要：**

| 你可以 | 你必须 | 你不能 |
|---|---|---|
| 在任何 Jellyfin 服务器上使用它，无论个人还是商业用途 | 在任何再分发中保留版权 + 许可声明 | 如果出现问题，要求作者承担责任 |
| 按你的意愿分叉和修改 | | 声称作者为你的分叉背书 |
| 再分发修改过或未修改的副本 | | |
| 将它和专有软件打包在一起 | | |
| 将它包含在付费产品中 | | |

如果你只是想*运行*这个插件，这些都不会影响到你 — 装上它，尽情享用。

### 贡献

欢迎提交 Pull Request。提交贡献即表示你同意你的改动将按相同的 MIT 条款授权。请保持贡献聚焦（每个 PR 只做一项功能或修复），并在 PR 正文中简要说明改了什么以及为什么。

### 第三方归属

- **Jellyfin**（GPL-2.0）— 本插件是针对 [Jellyfin](https://jellyfin.org/) 的第三方扩展，与 Jellyfin 项目无隶属关系，也未获其背书。构建时会引用 `Jellyfin.Controller` 和 `Jellyfin.Model` NuGet 包，它们仍处于各自的 GPL-2.0 许可证之下。
- **Xbox 风格解锁弹窗通知** — 其动画风格受 [Adam Cosman 的 Xbox One Achievement codepen](https://codepen.io/AdamCosman/pen/eYpNYgy) 启发，并从头重新实现。本插件不附带该 codepen 的任何原始素材。
- **Material Icons**（Apache 2.0）— UI 中引用的图标字形由 Jellyfin 自身的 Web 客户端提供，并由 Google 授权。
- **背景视频素材（v2.0）** — 取自公有领域 / 免版税素材库，并转码为 H.264 1080p 循环以便嵌入。不使用外部 CDN；所有素材都随插件 DLL 一起提供。

完整的许可证文本和第三方声明请参见 [LICENSE](../LICENSE)。

---

⭐ 如果你使用本插件，欢迎给仓库点个 Star。
