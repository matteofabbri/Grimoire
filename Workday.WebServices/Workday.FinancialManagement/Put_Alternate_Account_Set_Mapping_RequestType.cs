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
	public class Put_Alternate_Account_Set_Mapping_RequestType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType alternate_Account_Set_Mapping_ReferenceField;

		private Alternate_Account_Set_Mapping_DataType alternate_Account_Set_Mapping_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Alternate_Account_Set_Mapping_Reference
		{
			get
			{
				return this.alternate_Account_Set_Mapping_ReferenceField;
			}
			set
			{
				this.alternate_Account_Set_Mapping_ReferenceField = value;
				this.RaisePropertyChanged("Alternate_Account_Set_Mapping_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Alternate_Account_Set_Mapping_DataType Alternate_Account_Set_Mapping_Data
		{
			get
			{
				return this.alternate_Account_Set_Mapping_DataField;
			}
			set
			{
				this.alternate_Account_Set_Mapping_DataField = value;
				this.RaisePropertyChanged("Alternate_Account_Set_Mapping_Data");
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
