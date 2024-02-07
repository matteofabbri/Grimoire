using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Integration_Worktag_Mapping_RequestType : INotifyPropertyChanged
	{
		private Integration_Worktag_MappingObjectType integration_Worktag_Mapping_ReferenceField;

		private Integration_Worktag_Mapping_DataType integration_Worktag_Mapping_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Integration_Worktag_MappingObjectType Integration_Worktag_Mapping_Reference
		{
			get
			{
				return this.integration_Worktag_Mapping_ReferenceField;
			}
			set
			{
				this.integration_Worktag_Mapping_ReferenceField = value;
				this.RaisePropertyChanged("Integration_Worktag_Mapping_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Integration_Worktag_Mapping_DataType Integration_Worktag_Mapping_Data
		{
			get
			{
				return this.integration_Worktag_Mapping_DataField;
			}
			set
			{
				this.integration_Worktag_Mapping_DataField = value;
				this.RaisePropertyChanged("Integration_Worktag_Mapping_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Add_Only
		{
			get
			{
				return this.add_OnlyField;
			}
			set
			{
				this.add_OnlyField = value;
				this.RaisePropertyChanged("Add_Only");
			}
		}

		[XmlIgnore]
		public bool Add_OnlySpecified
		{
			get
			{
				return this.add_OnlyFieldSpecified;
			}
			set
			{
				this.add_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Add_OnlySpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
