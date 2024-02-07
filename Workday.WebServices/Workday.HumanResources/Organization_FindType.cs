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
	public class Organization_FindType : INotifyPropertyChanged
	{
		private DateTime as_Of_DateField;

		private bool as_Of_DateFieldSpecified;

		private string organization_NameField;

		private Business_Site_Reference_DataType location_Reference_DataField;

		private Employee_ReferenceType employee_Reference_DataField;

		private Contingent_Worker_Reference_DataType contingent_Worker_Reference_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
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

		[XmlElement(Order = 1)]
		public string Organization_Name
		{
			get
			{
				return this.organization_NameField;
			}
			set
			{
				this.organization_NameField = value;
				this.RaisePropertyChanged("Organization_Name");
			}
		}

		[XmlElement(Order = 2)]
		public Business_Site_Reference_DataType Location_Reference_Data
		{
			get
			{
				return this.location_Reference_DataField;
			}
			set
			{
				this.location_Reference_DataField = value;
				this.RaisePropertyChanged("Location_Reference_Data");
			}
		}

		[XmlElement(Order = 3)]
		public Employee_ReferenceType Employee_Reference_Data
		{
			get
			{
				return this.employee_Reference_DataField;
			}
			set
			{
				this.employee_Reference_DataField = value;
				this.RaisePropertyChanged("Employee_Reference_Data");
			}
		}

		[XmlElement(Order = 4)]
		public Contingent_Worker_Reference_DataType Contingent_Worker_Reference_Data
		{
			get
			{
				return this.contingent_Worker_Reference_DataField;
			}
			set
			{
				this.contingent_Worker_Reference_DataField = value;
				this.RaisePropertyChanged("Contingent_Worker_Reference_Data");
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
