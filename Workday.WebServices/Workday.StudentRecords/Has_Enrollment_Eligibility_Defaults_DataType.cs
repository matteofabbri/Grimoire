using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Has_Enrollment_Eligibility_Defaults_DataType : INotifyPropertyChanged
	{
		private bool unlimited_Orientation_CapacityField;

		private bool unlimited_Orientation_CapacityFieldSpecified;

		private decimal default_Orientation_CapacityField;

		private bool default_Orientation_CapacityFieldSpecified;

		private decimal default_Orientation_Projected_EnrollmentField;

		private bool default_Orientation_Projected_EnrollmentFieldSpecified;

		private decimal default_Orientation_Wait_List_CapacityField;

		private bool default_Orientation_Wait_List_CapacityFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Unlimited_Orientation_Capacity
		{
			get
			{
				return this.unlimited_Orientation_CapacityField;
			}
			set
			{
				this.unlimited_Orientation_CapacityField = value;
				this.RaisePropertyChanged("Unlimited_Orientation_Capacity");
			}
		}

		[XmlIgnore]
		public bool Unlimited_Orientation_CapacitySpecified
		{
			get
			{
				return this.unlimited_Orientation_CapacityFieldSpecified;
			}
			set
			{
				this.unlimited_Orientation_CapacityFieldSpecified = value;
				this.RaisePropertyChanged("Unlimited_Orientation_CapacitySpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Default_Orientation_Capacity
		{
			get
			{
				return this.default_Orientation_CapacityField;
			}
			set
			{
				this.default_Orientation_CapacityField = value;
				this.RaisePropertyChanged("Default_Orientation_Capacity");
			}
		}

		[XmlIgnore]
		public bool Default_Orientation_CapacitySpecified
		{
			get
			{
				return this.default_Orientation_CapacityFieldSpecified;
			}
			set
			{
				this.default_Orientation_CapacityFieldSpecified = value;
				this.RaisePropertyChanged("Default_Orientation_CapacitySpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Default_Orientation_Projected_Enrollment
		{
			get
			{
				return this.default_Orientation_Projected_EnrollmentField;
			}
			set
			{
				this.default_Orientation_Projected_EnrollmentField = value;
				this.RaisePropertyChanged("Default_Orientation_Projected_Enrollment");
			}
		}

		[XmlIgnore]
		public bool Default_Orientation_Projected_EnrollmentSpecified
		{
			get
			{
				return this.default_Orientation_Projected_EnrollmentFieldSpecified;
			}
			set
			{
				this.default_Orientation_Projected_EnrollmentFieldSpecified = value;
				this.RaisePropertyChanged("Default_Orientation_Projected_EnrollmentSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Default_Orientation_Wait_List_Capacity
		{
			get
			{
				return this.default_Orientation_Wait_List_CapacityField;
			}
			set
			{
				this.default_Orientation_Wait_List_CapacityField = value;
				this.RaisePropertyChanged("Default_Orientation_Wait_List_Capacity");
			}
		}

		[XmlIgnore]
		public bool Default_Orientation_Wait_List_CapacitySpecified
		{
			get
			{
				return this.default_Orientation_Wait_List_CapacityFieldSpecified;
			}
			set
			{
				this.default_Orientation_Wait_List_CapacityFieldSpecified = value;
				this.RaisePropertyChanged("Default_Orientation_Wait_List_CapacitySpecified");
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
