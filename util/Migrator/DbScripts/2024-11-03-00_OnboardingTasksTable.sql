IF OBJECT_ID('[dbo].[VaultTasks]') IS NULL
BEGIN
    CREATE TABLE [dbo].[VaultTasks] (
        [Id] UNIQUEIDENTIFIER NOT NULL,
        [VaultTask] VARCHAR(50) NOT NULL,
        [VaultTaskVal] VARCHAR(50) NOT NULL
        );
END;
-- HOW TO CREATE AN EF MIGRATION OF THIS? TODO
