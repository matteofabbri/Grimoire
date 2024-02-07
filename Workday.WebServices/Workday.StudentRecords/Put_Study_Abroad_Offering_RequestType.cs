using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Study_Abroad_Offering_RequestType : INotifyPropertyChanged
	{
		private Study_Abroad_OfferingObjectType study_Abroad_Offering_ReferenceField;

		private Study_Abroad_Offering_DataType study_Abroad_Offering_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Study_Abroad_OfferingObjectType Study_Abroad_Offering_Reference
		{
			get
			{
				return this.study_Abroad_Offering_ReferenceField;
			}
			set
			{
				this.study_Abroad_Offering_ReferenceField = value;
				this.RaisePropertyChanged("Study_Abroad_Offering_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Study_Abroad_Offering_DataType Study_Abroad_Offering_Data
		{
			get
			{
				return this.study_Abroad_Offering_DataField;
			}
			set
			{
				this.study_Abroad_Offering_DataField = value;
				this.RaisePropertyChanged("Study_Abroad_Offering_Data");
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
