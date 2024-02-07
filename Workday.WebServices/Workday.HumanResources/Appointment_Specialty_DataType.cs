using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Appointment_Specialty_DataType : INotifyPropertyChanged
	{
		private string idField;

		private SpecialtyObjectType specialty_ReferenceField;

		private Academic_Appointment_SetObjectType academic_Unit_or_Academic_Unit_Hierarchy_ReferenceField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

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
		public SpecialtyObjectType Specialty_Reference
		{
			get
			{
				return this.specialty_ReferenceField;
			}
			set
			{
				this.specialty_ReferenceField = value;
				this.RaisePropertyChanged("Specialty_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Academic_Appointment_SetObjectType Academic_Unit_or_Academic_Unit_Hierarchy_Reference
		{
			get
			{
				return this.academic_Unit_or_Academic_Unit_Hierarchy_ReferenceField;
			}
			set
			{
				this.academic_Unit_or_Academic_Unit_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Unit_or_Academic_Unit_Hierarchy_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
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
