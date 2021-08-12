USE [nutrition_db]
GO
SET IDENTITY_INSERT [dbo].[Vitamins] ON 
GO
INSERT [dbo].[Vitamins] ([Id], [VitaminName]) VALUES (1, N'Vitamin A')
GO
INSERT [dbo].[Vitamins] ([Id], [VitaminName]) VALUES (2, N'Vitamin B')
GO
INSERT [dbo].[Vitamins] ([Id], [VitaminName]) VALUES (3, N'Vitamin C')
GO
INSERT [dbo].[Vitamins] ([Id], [VitaminName]) VALUES (4, N'Vitamin D')
GO
INSERT [dbo].[Vitamins] ([Id], [VitaminName]) VALUES (5, N'Vitamin E')
GO
INSERT [dbo].[Vitamins] ([Id], [VitaminName]) VALUES (6, N'Vitamin K')
GO
INSERT [dbo].[Vitamins] ([Id], [VitaminName]) VALUES (7, NULL)
GO
SET IDENTITY_INSERT [dbo].[Vitamins] OFF
GO
SET IDENTITY_INSERT [dbo].[Diseases] ON 
GO
INSERT [dbo].[Diseases] ([Id], [DiseaseName], [Description], [VitaminId]) VALUES (1, N'Dry Skin', N'Eczema is a condition that causes dry, itchy and inflamed skin. Several clinical studies have shown alitretinoin, a prescription medication with vitamin A activity, to be effective in treating eczema', 1)
GO
INSERT [dbo].[Diseases] ([Id], [DiseaseName], [Description], [VitaminId]) VALUES (2, N'Dry Eyes', N'Dry eyes, or the inability to produce tears, is one of the first signs of vitamin A deficiency.', 1)
GO
INSERT [dbo].[Diseases] ([Id], [DiseaseName], [Description], [VitaminId]) VALUES (3, N'Anemia', N'A condition in which the blood doesn''t have enough healthy red blood cells.', 2)
GO
INSERT [dbo].[Diseases] ([Id], [DiseaseName], [Description], [VitaminId]) VALUES (4, N'Scurvy', N'A condition caused by a severe lack of vitamin C in the diet. Vitamin C is found in citrus fruits and vegetables. Scurvy results from a deficiency of vitamin C in the diet.', 3)
GO
INSERT [dbo].[Diseases] ([Id], [DiseaseName], [Description], [VitaminId]) VALUES (5, N'Rickets ', N'Rickets is the softening and weakening of bones in children, usually because of an extreme and prolonged vitamin D deficiency. Rare inherited problems also can cause rickets.', 4)
GO
INSERT [dbo].[Diseases] ([Id], [DiseaseName], [Description], [VitaminId]) VALUES (6, N'Liver disorders', N'Any condition that damages the liver and prevents it from functioning well.', 5)
GO
INSERT [dbo].[Diseases] ([Id], [DiseaseName], [Description], [VitaminId]) VALUES (7, N'Hemorrhagic Disease of the Newborn', N'Vitamin K deficiency bleeding (VKDB) is a bleeding problem that occurs in some newborns during the first few days of life. VKDB was previously called hemorrhagic disease of the newborn.', 6)
GO
SET IDENTITY_INSERT [dbo].[Diseases] OFF
GO
SET IDENTITY_INSERT [dbo].[Foods] ON 
GO
INSERT [dbo].[Foods] ([Id], [FoodName], [Details], [VitaminId]) VALUES (1, N'Eggs', N'Eggs are laid by female animals of many different species, including birds, reptiles, amphibians, a few mammals, and fish, and many of these have been eaten by humans for thousands of years', 1)
GO
INSERT [dbo].[Foods] ([Id], [FoodName], [Details], [VitaminId]) VALUES (2, N'Yoghurt', N'Yogurt also spelled yoghurt, yogourt or yoghourt, is a food produced by bacterial fermentation of milk. ', 1)
GO
INSERT [dbo].[Foods] ([Id], [FoodName], [Details], [VitaminId]) VALUES (3, N'Nuts', N'A nut is a fruit consisting of a hard or tough nutshell protecting a kernel which is usually edible. In general usage and in a culinary sense, a wide variety of dry seeds are called nuts', 2)
GO
INSERT [dbo].[Foods] ([Id], [FoodName], [Details], [VitaminId]) VALUES (4, N'Broccoli', N'Broccoli is an edible green plant in the cabbage family whose large flowering head, stalk and small associated leaves are eaten as a vegetable.', 3)
GO
INSERT [dbo].[Foods] ([Id], [FoodName], [Details], [VitaminId]) VALUES (5, N'Red Meat', N'In gastronomy, red meat is commonly red when raw and a dark color after it is cooked, in contrast to white meat, which is pale in color before and after cooking. In culinary terms, only flesh from mammals or fowl is classified as red or white', 4)
GO
INSERT [dbo].[Foods] ([Id], [FoodName], [Details], [VitaminId]) VALUES (6, N'Wheatgerm ', N'The germ of a cereal is the reproductive part that germinates to grow into a plant; it is the embryo of the seed. Along with bran, germ is often a by-product of the milling that produces refined grain products.', 5)
GO
INSERT [dbo].[Foods] ([Id], [FoodName], [Details], [VitaminId]) VALUES (7, N'Spinach', N'Spinach is a leafy green flowering plant native to central and western Asia. It is of the order Caryophyllales, family Amaranthaceae, subfamily Chenopodioideae. Its leaves are a common edible vegetable consumed either fresh, or after storage using preservation techniques by canning, freezing, or dehydration.', 6)
GO
SET IDENTITY_INSERT [dbo].[Foods] OFF
GO
SET IDENTITY_INSERT [dbo].[Supplements] ON 
GO
INSERT [dbo].[Supplements] ([Id], [SupplementName], [CompanyName], [Price], [VitaminId]) VALUES (1, N'Vitamin A Vegetarian Capsule', N'Vitawin ', 10.5, 1)
GO
INSERT [dbo].[Supplements] ([Id], [SupplementName], [CompanyName], [Price], [VitaminId]) VALUES (2, N'Big 100 - Vitamin B-Complex Formula - 100 Vegetarian Tablets', N'GNC', 60.8, 2)
GO
INSERT [dbo].[Supplements] ([Id], [SupplementName], [CompanyName], [Price], [VitaminId]) VALUES (3, N'Grapeseed & Vitamin C Capsules', N'MyVitamins', 32.5, 3)
GO
INSERT [dbo].[Supplements] ([Id], [SupplementName], [CompanyName], [Price], [VitaminId]) VALUES (4, N'D3K2+ (Plant based D3 K2 with Curcumin, Ashwagandha & Rosemary) for Anti-Inflammation, Mood & Immunity, 60 veg Capsules', N'OZiva', 26.5, 4)
GO
INSERT [dbo].[Supplements] ([Id], [SupplementName], [CompanyName], [Price], [VitaminId]) VALUES (5, N'AQUAMIN® MAGNESIUM PREVIOUS Aquamin Magnesium Tablets TOCOTRIENOLS', N'Body 3 First', 30.6, 5)
GO
INSERT [dbo].[Supplements] ([Id], [SupplementName], [CompanyName], [Price], [VitaminId]) VALUES (6, N'Vitamin K 55mcg Capsule', N'HealthVit ', 8.5, 6)
GO
SET IDENTITY_INSERT [dbo].[Supplements] OFF
GO
