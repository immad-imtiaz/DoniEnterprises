﻿CREATE TABLE [dbo].[TransactionsCommission] (
    [tr_transactionID]          BIGINT        NOT NULL,
    [tr_brokerInvolved]         BIT           NULL,
    [tr_sellerBroker]           BIT           DEFAULT ((0)) NULL,
    [tr_sellerBrokerID]         BIGINT        NULL,
    [tr_sellerBroker_comm_type] NVARCHAR (50) NULL,
    [tr_sellerBroker_comm]      INT           DEFAULT ((0)) NULL,
    [tr_buyerBroker]            BIT           DEFAULT ((0)) NULL,
    [tr_buyerBrokerID]          BIGINT        NULL,
    [tr_buyerBroker_comm_type]  NVARCHAR (50) NULL,
    [tr_buyerBroker_comm]       INT           DEFAULT ((0)) NULL,
    [tr_own_Commission]         INT           DEFAULT ((0)) NULL,
    [tr_ownCommissionType]      NVARCHAR (50) NULL,
    [tr_difference]             INT           DEFAULT ((0)) NULL,
    [tr_discount]               INT           DEFAULT ((0)) NULL,
    [tr_netCommission]          INT           DEFAULT ((0)) NULL,
    [tr_createdBy]              INT           NOT NULL,
    [tr_createdOn]              DATETIME      NULL,
    [tr_editedBy]               INT           NULL,
    [tr_editedOn]               DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([tr_transactionID] ASC),
    FOREIGN KEY ([tr_buyerBrokerID]) REFERENCES [dbo].[BusinessPartner] ([bp_ID]),
    FOREIGN KEY ([tr_createdBy]) REFERENCES [dbo].[AppUsers] ([UserID]),
    FOREIGN KEY ([tr_editedBy]) REFERENCES [dbo].[AppUsers] ([UserID]),
    FOREIGN KEY ([tr_sellerBrokerID]) REFERENCES [dbo].[BusinessPartner] ([bp_ID]),
    FOREIGN KEY ([tr_transactionID]) REFERENCES [dbo].[Transactions] ([tr_transactionID])
);

