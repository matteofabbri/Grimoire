using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.WorkforcePlanning
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Organizations_to_Exclude_Detail_DataType : INotifyPropertyChanged
	{
		private bool exclude_Subordinate_OrganizationsField;

		private bool exclude_Subordinate_OrganizationsFieldSpecified;

		private bool promote_Subordinate_OrganizationsField;

		private bool promote_Subordinate_OrganizationsFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Exclude_Subordinate_Organizations
		{
			get
			{
				return this.exclude_Subordinate_OrganizationsField;
			}
			set
			{
				this.exclude_Subordinate_OrganizationsField = value;
				this.RaisePropertyChanged("Exclude_Subordinate_Organizations");
			}
		}

		[XmlIgnore]
		public bool Exclude_Subordinate_OrganizationsSpecified
		{
			get
			{
				return this.exclude_Subordinate_OrganizationsFieldSpecified;
			}
			set
			{
				this.exclude_Subordinate_OrganizationsFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Subordinate_OrganizationsSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Promote_Subordinate_Organizations
		{
			get
			{
				return this.promote_Subordinate_OrganizationsField;
			}
			set
			{
				this.promote_Subordinate_OrganizationsField = value;
				this.RaisePropertyChanged("Promote_Subordinate_Organizations");
			}
		}

		[XmlIgnore]
		public bool Promote_Subordinate_OrganizationsSpecified
		{
			get
			{
				return this.promote_Subordinate_OrganizationsFieldSpecified;
			}
			set
			{
				this.promote_Subordinate_OrganizationsFieldSpecified = value;
				this.RaisePropertyChanged("Promote_Subordinate_OrganizationsSpecified");
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
