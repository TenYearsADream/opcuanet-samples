﻿'Copyright (c) Traeger Industry Components GmbH. All Rights Reserved.

Imports Opc.UaFx

Namespace NodeTypes
    Friend Class MySimpleObjectNode
        Inherits OpcObjectNode

#Region "---------- Public constructors ----------"

        Public Sub New(ByVal name As OpcName)
            MyBase.New(name)
        End Sub

        Public Sub New(ByVal parent As IOpcNode, ByVal name As OpcName)
            MyBase.New(parent, name)
        End Sub

#End Region

#Region "---------- Protected properties ----------"

        Protected Overrides ReadOnly Property DefaultTypeDefinitionId As OpcNodeId
            Get
                Return "ns=1;s=MySimpleObjectType"
            End Get
        End Property

#End Region
    End Class
End Namespace
