using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Integration_Worktag_Mapping_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string mapping_NameField;

		private Integration_Worktag_Mapping_Source_SystemObjectType source_System_ReferenceField;

		private Account_SetObjectType account_Set_ReferenceField;

		private string commentField;

		private Integration_Worktag_Mapping_DetailType[] mapping_DetailField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Mapping_Name
		{
			get
			{
				return this.mapping_NameField;
			}
			set
			{
				this.mapping_NameField = value;
				this.RaisePropertyChanged("Mapping_Name");
			}
		}

		[XmlElement(Order = 2)]
		public Integration_Worktag_Mapping_Source_SystemObjectType Source_System_Reference
		{
			get
			{
				return this.source_System_ReferenceField;
			}
			set
			{
				this.source_System_ReferenceField = value;
				this.RaisePropertyChanged("Source_System_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Account_SetObjectType Account_Set_Reference
		{
			get
			{
				return this.account_Set_ReferenceField;
			}
			set
			{
				this.account_Set_ReferenceField = value;
				this.RaisePropertyChanged("Account_Set_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public string Comment
		{
			get
			{
				return this.commentField;
			}
			set
			{
				this.commentField = value;
				this.RaisePropertyChanged("Comment");
			}
		}

		[XmlElement("Mapping_Detail", Order = 5)]
		public Integration_Worktag_Mapping_DetailType[] Mapping_Detail
		{
			get
			{
				return this.mapping_DetailField;
			}
			set
			{
				this.mapping_DetailField = value;
				this.RaisePropertyChanged("Mapping_Detail");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
