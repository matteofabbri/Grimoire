using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "External_Disability_Self-Identification_Record_DataType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class External_Disability_SelfIdentification_Record_DataType : INotifyPropertyChanged
	{
		private string idField;

		private EmployeeObjectType employee_ReferenceField;

		private SelfIdentification_of_Disability_StatusObjectType disability_Status_ReferenceField;

		private DateTime invitation_DateField;

		private bool invitation_DateFieldSpecified;

		private DateTime response_DateField;

		private bool response_DateFieldSpecified;

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
		public EmployeeObjectType Employee_Reference
		{
			get
			{
				return this.employee_ReferenceField;
			}
			set
			{
				this.employee_ReferenceField = value;
				this.RaisePropertyChanged("Employee_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public SelfIdentification_of_Disability_StatusObjectType Disability_Status_Reference
		{
			get
			{
				return this.disability_Status_ReferenceField;
			}
			set
			{
				this.disability_Status_ReferenceField = value;
				this.RaisePropertyChanged("Disability_Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Invitation_Date
		{
			get
			{
				return this.invitation_DateField;
			}
			set
			{
				this.invitation_DateField = value;
				this.RaisePropertyChanged("Invitation_Date");
			}
		}

		[XmlIgnore]
		public bool Invitation_DateSpecified
		{
			get
			{
				return this.invitation_DateFieldSpecified;
			}
			set
			{
				this.invitation_DateFieldSpecified = value;
				this.RaisePropertyChanged("Invitation_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Response_Date
		{
			get
			{
				return this.response_DateField;
			}
			set
			{
				this.response_DateField = value;
				this.RaisePropertyChanged("Response_Date");
			}
		}

		[XmlIgnore]
		public bool Response_DateSpecified
		{
			get
			{
				return this.response_DateFieldSpecified;
			}
			set
			{
				this.response_DateFieldSpecified = value;
				this.RaisePropertyChanged("Response_DateSpecified");
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
