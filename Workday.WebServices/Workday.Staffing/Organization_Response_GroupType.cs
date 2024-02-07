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
	public class Organization_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_Roles_DataField;

		private bool include_Roles_DataFieldSpecified;

		private bool include_Hierarchy_DataField;

		private bool include_Hierarchy_DataFieldSpecified;

		private bool include_Supervisory_DataField;

		private bool include_Supervisory_DataFieldSpecified;

		private bool include_Staffing_Restrictions_DataField;

		private bool include_Staffing_Restrictions_DataFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Include_Roles_Data
		{
			get
			{
				return this.include_Roles_DataField;
			}
			set
			{
				this.include_Roles_DataField = value;
				this.RaisePropertyChanged("Include_Roles_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Roles_DataSpecified
		{
			get
			{
				return this.include_Roles_DataFieldSpecified;
			}
			set
			{
				this.include_Roles_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Roles_DataSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Include_Hierarchy_Data
		{
			get
			{
				return this.include_Hierarchy_DataField;
			}
			set
			{
				this.include_Hierarchy_DataField = value;
				this.RaisePropertyChanged("Include_Hierarchy_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Hierarchy_DataSpecified
		{
			get
			{
				return this.include_Hierarchy_DataFieldSpecified;
			}
			set
			{
				this.include_Hierarchy_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Hierarchy_DataSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Supervisory_Data
		{
			get
			{
				return this.include_Supervisory_DataField;
			}
			set
			{
				this.include_Supervisory_DataField = value;
				this.RaisePropertyChanged("Include_Supervisory_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Supervisory_DataSpecified
		{
			get
			{
				return this.include_Supervisory_DataFieldSpecified;
			}
			set
			{
				this.include_Supervisory_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Supervisory_DataSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Include_Staffing_Restrictions_Data
		{
			get
			{
				return this.include_Staffing_Restrictions_DataField;
			}
			set
			{
				this.include_Staffing_Restrictions_DataField = value;
				this.RaisePropertyChanged("Include_Staffing_Restrictions_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Staffing_Restrictions_DataSpecified
		{
			get
			{
				return this.include_Staffing_Restrictions_DataFieldSpecified;
			}
			set
			{
				this.include_Staffing_Restrictions_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Staffing_Restrictions_DataSpecified");
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
