SET IDENTITY_INSERT [dbo].[Application] ON
INSERT INTO [dbo].[Application] ([Id], [AdvertisementId], [ApplicantId]) VALUES (1, 1, 1)
INSERT INTO [dbo].[Application] ([Id], [AdvertisementId], [ApplicantId]) VALUES (2, 2, 2)
INSERT INTO [dbo].[Application] ([Id], [AdvertisementId], [ApplicantId]) VALUES (3, 1, 2)
SET IDENTITY_INSERT [dbo].[Application] OFF
