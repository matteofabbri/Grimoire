using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Contingent_Worker_GetType : INotifyPropertyChanged
	{
		private Contingent_Worker_Reference_DataType contingent_Worker_ReferenceField;

		private DateTime as_Of_DateField;

		private bool as_Of_DateFieldSpecified;

		private DateTime as_Of_MomentField;

		private bool as_Of_MomentFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Contingent_Worker_Reference_DataType Contingent_Worker_Reference
		{
			get
			{
				return this.contingent_Worker_ReferenceField;
			}
			set
			{
				this.contingent_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Contingent_Worker_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified, DataType = "date")]
		public DateTime As_Of_Date
		{
			get
			{
				return this.as_Of_DateField;
			}
			set
			{
				this.as_Of_DateField = value;
				this.RaisePropertyChanged("As_Of_Date");
			}
		}

		[XmlIgnore]
		public bool As_Of_DateSpecified
		{
			get
			{
				return this.as_Of_DateFieldSpecified;
			}
			set
			{
				this.as_Of_DateFieldSpecified = value;
				this.RaisePropertyChanged("As_Of_DateSpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public DateTime As_Of_Moment
		{
			get
			{
				return this.as_Of_MomentField;
			}
			set
			{
				this.as_Of_MomentField = value;
				this.RaisePropertyChanged("As_Of_Moment");
			}
		}

		[XmlIgnore]
		public bool As_Of_MomentSpecified
		{
			get
			{
				return this.as_Of_MomentFieldSpecified;
			}
			set
			{
				this.as_Of_MomentFieldSpecified = value;
				this.RaisePropertyChanged("As_Of_MomentSpecified");
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
