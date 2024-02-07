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
	public class Put_Subrecipient_Risk_Record_RequestType : INotifyPropertyChanged
	{
		private Risk_EvaluationObjectType subrecipient_Risk_Record_ReferenceField;

		private Subrecipient_Risk_Record_DataType subrecipient_Risk_Record_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Risk_EvaluationObjectType Subrecipient_Risk_Record_Reference
		{
			get
			{
				return this.subrecipient_Risk_Record_ReferenceField;
			}
			set
			{
				this.subrecipient_Risk_Record_ReferenceField = value;
				this.RaisePropertyChanged("Subrecipient_Risk_Record_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Subrecipient_Risk_Record_DataType Subrecipient_Risk_Record_Data
		{
			get
			{
				return this.subrecipient_Risk_Record_DataField;
			}
			set
			{
				this.subrecipient_Risk_Record_DataField = value;
				this.RaisePropertyChanged("Subrecipient_Risk_Record_Data");
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
