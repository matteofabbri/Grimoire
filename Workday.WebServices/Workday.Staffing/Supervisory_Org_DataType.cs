using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Supervisory_Org_DataType : INotifyPropertyChanged
	{
		private string staffing_ModelField;

		private LocationObjectType location_ReferenceField;

		private Organization_Assignments_DataType[] organization_Assignments_DataField;

		private Position_Group_Restriction_Summary_DataType staffing_Restrictions_DataField;

		private bool available_For_HireField;

		private bool available_For_HireFieldSpecified;

		private bool hiring_FreezeField;

		private bool hiring_FreezeFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Staffing_Model
		{
			get
			{
				return this.staffing_ModelField;
			}
			set
			{
				this.staffing_ModelField = value;
				this.RaisePropertyChanged("Staffing_Model");
			}
		}

		[XmlElement(Order = 1)]
		public LocationObjectType Location_Reference
		{
			get
			{
				return this.location_ReferenceField;
			}
			set
			{
				this.location_ReferenceField = value;
				this.RaisePropertyChanged("Location_Reference");
			}
		}

		[XmlElement("Organization_Assignments_Data", Order = 2)]
		public Organization_Assignments_DataType[] Organization_Assignments_Data
		{
			get
			{
				return this.organization_Assignments_DataField;
			}
			set
			{
				this.organization_Assignments_DataField = value;
				this.RaisePropertyChanged("Organization_Assignments_Data");
			}
		}

		[XmlElement(Order = 3)]
		public Position_Group_Restriction_Summary_DataType Staffing_Restrictions_Data
		{
			get
			{
				return this.staffing_Restrictions_DataField;
			}
			set
			{
				this.staffing_Restrictions_DataField = value;
				this.RaisePropertyChanged("Staffing_Restrictions_Data");
			}
		}

		[XmlElement(Order = 4)]
		public bool Available_For_Hire
		{
			get
			{
				return this.available_For_HireField;
			}
			set
			{
				this.available_For_HireField = value;
				this.RaisePropertyChanged("Available_For_Hire");
			}
		}

		[XmlIgnore]
		public bool Available_For_HireSpecified
		{
			get
			{
				return this.available_For_HireFieldSpecified;
			}
			set
			{
				this.available_For_HireFieldSpecified = value;
				this.RaisePropertyChanged("Available_For_HireSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Hiring_Freeze
		{
			get
			{
				return this.hiring_FreezeField;
			}
			set
			{
				this.hiring_FreezeField = value;
				this.RaisePropertyChanged("Hiring_Freeze");
			}
		}

		[XmlIgnore]
		public bool Hiring_FreezeSpecified
		{
			get
			{
				return this.hiring_FreezeFieldSpecified;
			}
			set
			{
				this.hiring_FreezeFieldSpecified = value;
				this.RaisePropertyChanged("Hiring_FreezeSpecified");
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
