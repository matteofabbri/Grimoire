using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Put_One-Time_Payment_Plan_Configurable_Category_RequestType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_OneTime_Payment_Plan_Configurable_Category_RequestType : INotifyPropertyChanged
	{
		private OneTime_Payment_Plan_Configurable_CategoryObjectType oneTime_Payment_Plan_Configurable_Category_ReferenceField;

		private OneTime_Payment_Plan_Configurable_Category_DataType oneTime_Payment_Plan_Configurable_Category_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("One-Time_Payment_Plan_Configurable_Category_Reference", Order = 0)]
		public OneTime_Payment_Plan_Configurable_CategoryObjectType OneTime_Payment_Plan_Configurable_Category_Reference
		{
			get
			{
				return this.oneTime_Payment_Plan_Configurable_Category_ReferenceField;
			}
			set
			{
				this.oneTime_Payment_Plan_Configurable_Category_ReferenceField = value;
				this.RaisePropertyChanged("OneTime_Payment_Plan_Configurable_Category_Reference");
			}
		}

		[XmlElement("One-Time_Payment_Plan_Configurable_Category_Data", Order = 1)]
		public OneTime_Payment_Plan_Configurable_Category_DataType OneTime_Payment_Plan_Configurable_Category_Data
		{
			get
			{
				return this.oneTime_Payment_Plan_Configurable_Category_DataField;
			}
			set
			{
				this.oneTime_Payment_Plan_Configurable_Category_DataField = value;
				this.RaisePropertyChanged("OneTime_Payment_Plan_Configurable_Category_Data");
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
