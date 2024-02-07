using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Asset_Useful_Life_for_Reclassify_DataType : INotifyPropertyChanged
	{
		private Asset_BookObjectType asset_Book_ReferenceField;

		private decimal proposed_Useful_LifeField;

		private bool proposed_Useful_LifeFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Asset_BookObjectType Asset_Book_Reference
		{
			get
			{
				return this.asset_Book_ReferenceField;
			}
			set
			{
				this.asset_Book_ReferenceField = value;
				this.RaisePropertyChanged("Asset_Book_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Proposed_Useful_Life
		{
			get
			{
				return this.proposed_Useful_LifeField;
			}
			set
			{
				this.proposed_Useful_LifeField = value;
				this.RaisePropertyChanged("Proposed_Useful_Life");
			}
		}

		[XmlIgnore]
		public bool Proposed_Useful_LifeSpecified
		{
			get
			{
				return this.proposed_Useful_LifeFieldSpecified;
			}
			set
			{
				this.proposed_Useful_LifeFieldSpecified = value;
				this.RaisePropertyChanged("Proposed_Useful_LifeSpecified");
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
