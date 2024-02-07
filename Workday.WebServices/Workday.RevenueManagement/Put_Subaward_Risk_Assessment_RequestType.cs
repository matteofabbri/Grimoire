using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Subaward_Risk_Assessment_RequestType : INotifyPropertyChanged
	{
		private Risk_EvaluationObjectType subaward_Risk_Assessment_ReferenceField;

		private Subaward_Risk_Assessment_DataType subaward_Risk_Assessment_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Risk_EvaluationObjectType Subaward_Risk_Assessment_Reference
		{
			get
			{
				return this.subaward_Risk_Assessment_ReferenceField;
			}
			set
			{
				this.subaward_Risk_Assessment_ReferenceField = value;
				this.RaisePropertyChanged("Subaward_Risk_Assessment_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Subaward_Risk_Assessment_DataType Subaward_Risk_Assessment_Data
		{
			get
			{
				return this.subaward_Risk_Assessment_DataField;
			}
			set
			{
				this.subaward_Risk_Assessment_DataField = value;
				this.RaisePropertyChanged("Subaward_Risk_Assessment_Data");
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
