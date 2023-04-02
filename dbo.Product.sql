CREATE TABLE [dbo].[Product] (
    [PID]     INT             NOT NULL,
    [ICMID]   INT             NULL,
    [Size]    INT             NULL,
    [Price]   REAL            NULL,
    [COLOR]   NVARCHAR (25)   NULL,
    [Quality] NVARCHAR (25)   NULL,
    [IMG]     IMAGE NULL,
    PRIMARY KEY CLUSTERED ([PID] ASC),
    CONSTRAINT [InventoryControlManager_Product_ICMID] FOREIGN KEY ([ICMID]) REFERENCES [dbo].[InventoryControlManager] ([ICMID])
);

