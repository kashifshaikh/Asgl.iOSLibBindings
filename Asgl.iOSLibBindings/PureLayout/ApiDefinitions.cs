using System.Drawing;
using Foundation;
using UIKit;

namespace Asgl.iOSLibBindings.PureLayout
{
	// typedef void (^ALConstraintsBlock)();
	delegate void ALConstraintsBlock ();

	// @interface PureLayout (UIView)
	[Category]
	[BaseType (typeof(UIView))]

	// KASHIF: Margin-methods only available on iOS8+
	interface UIView_PureLayout
	{
		// +(instancetype)newAutoLayoutView;
		[Static]
		[Export ("newAutoLayoutView")]
		UIView NewAutoLayoutView ();

		// +(NSArray *)autoCreateConstraintsWithoutInstalling:(ALConstraintsBlock)block;
		[Static]
		[Export ("autoCreateConstraintsWithoutInstalling:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] AutoCreateConstraintsWithoutInstalling (ALConstraintsBlock block);

		// +(void)autoSetPriority:(UILayoutPriority)priority forConstraints:(ALConstraintsBlock)block;
		[Static]
		[Export ("autoSetPriority:forConstraints:")]
		void AutoSetPriority (float priority, ALConstraintsBlock block);

		// +(void)autoSetIdentifier:(NSString *)identifier forConstraints:(ALConstraintsBlock)block;
		[Static]
		[Export ("autoSetIdentifier:forConstraints:")]
		void AutoSetIdentifier (string identifier, ALConstraintsBlock block);

		// -(NSArray *)autoCenterInSuperview;
		[Export ("autoCenterInSuperview")]
		//[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] AutoCenterInSuperview();

		// -(NSLayoutConstraint *)autoAlignAxisToSuperviewAxis:(ALAxis)axis;
		[Export ("autoAlignAxisToSuperviewAxis:")]
		NSLayoutConstraint AutoAlignAxisToSuperviewAxis (ALAxis axis);

		// -(NSArray *)autoCenterInSuperviewMargins;
		[Export ("autoCenterInSuperviewMargins")]
		//[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] AutoCenterInSuperviewMargins();

		// -(NSLayoutConstraint *)autoAlignAxisToSuperviewMarginAxis:(ALAxis)axis;
		[Export ("autoAlignAxisToSuperviewMarginAxis:")]
		NSLayoutConstraint AutoAlignAxisToSuperviewMarginAxis (ALAxis axis);

		// -(NSLayoutConstraint *)autoPinEdgeToSuperviewEdge:(ALEdge)edge;
		[Export ("autoPinEdgeToSuperviewEdge:")]
		NSLayoutConstraint AutoPinEdgeToSuperviewEdge (ALEdge edge);

		// -(NSLayoutConstraint *)autoPinEdgeToSuperviewEdge:(ALEdge)edge withInset:(CGFloat)inset;
		[Export ("autoPinEdgeToSuperviewEdge:withInset:")]
		NSLayoutConstraint AutoPinEdgeToSuperviewEdge (ALEdge edge, float inset);

		// -(NSLayoutConstraint *)autoPinEdgeToSuperviewEdge:(ALEdge)edge withInset:(CGFloat)inset relation:(NSLayoutRelation)relation;
		[Export ("autoPinEdgeToSuperviewEdge:withInset:relation:")]
		NSLayoutConstraint AutoPinEdgeToSuperviewEdge (ALEdge edge, float inset, NSLayoutRelation relation);

		// -(NSArray *)autoPinEdgesToSuperviewEdgesWithInsets:(UIEdgeInsets)insets;
		[Export ("autoPinEdgesToSuperviewEdgesWithInsets:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] AutoPinEdgesToSuperviewEdgesWithInsets (UIEdgeInsets insets);

		// -(NSArray *)autoPinEdgesToSuperviewEdgesWithInsets:(UIEdgeInsets)insets excludingEdge:(ALEdge)edge;
		[Export ("autoPinEdgesToSuperviewEdgesWithInsets:excludingEdge:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] AutoPinEdgesToSuperviewEdgesWithInsets (UIEdgeInsets insets, ALEdge edge);

		// -(NSLayoutConstraint *)autoPinEdgeToSuperviewMargin:(ALEdge)edge;
		[Export ("autoPinEdgeToSuperviewMargin:")]
		NSLayoutConstraint AutoPinEdgeToSuperviewMargin (ALEdge edge);

		// -(NSLayoutConstraint *)autoPinEdgeToSuperviewMargin:(ALEdge)edge relation:(NSLayoutRelation)relation;
		[Export ("autoPinEdgeToSuperviewMargin:relation:")]
		NSLayoutConstraint AutoPinEdgeToSuperviewMargin (ALEdge edge, NSLayoutRelation relation);

		// -(NSArray *)autoPinEdgesToSuperviewMargins;
		[Export ("autoPinEdgesToSuperviewMargins")]
		//[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] AutoPinEdgesToSuperviewMargins();

		// -(NSArray *)autoPinEdgesToSuperviewMarginsExcludingEdge:(ALEdge)edge;
		[Export ("autoPinEdgesToSuperviewMarginsExcludingEdge:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] AutoPinEdgesToSuperviewMarginsExcludingEdge (ALEdge edge);

		// -(NSLayoutConstraint *)autoPinEdge:(ALEdge)edge toEdge:(ALEdge)toEdge ofView:(UIView *)otherView;
		[Export ("autoPinEdge:toEdge:ofView:")]
		NSLayoutConstraint AutoPinEdge (ALEdge edge, ALEdge toEdge, UIView otherView);

		// -(NSLayoutConstraint *)autoPinEdge:(ALEdge)edge toEdge:(ALEdge)toEdge ofView:(UIView *)otherView withOffset:(CGFloat)offset;
		[Export ("autoPinEdge:toEdge:ofView:withOffset:")]
		NSLayoutConstraint AutoPinEdge (ALEdge edge, ALEdge toEdge, UIView otherView, float offset);

		// -(NSLayoutConstraint *)autoPinEdge:(ALEdge)edge toEdge:(ALEdge)toEdge ofView:(UIView *)otherView withOffset:(CGFloat)offset relation:(NSLayoutRelation)relation;
		[Export ("autoPinEdge:toEdge:ofView:withOffset:relation:")]
		NSLayoutConstraint AutoPinEdge (ALEdge edge, ALEdge toEdge, UIView otherView, float offset, NSLayoutRelation relation);

		// -(NSLayoutConstraint *)autoAlignAxis:(ALAxis)axis toSameAxisOfView:(UIView *)otherView;
		[Export ("autoAlignAxis:toSameAxisOfView:")]
		NSLayoutConstraint AutoAlignAxis (ALAxis axis, UIView otherView);

		// -(NSLayoutConstraint *)autoAlignAxis:(ALAxis)axis toSameAxisOfView:(UIView *)otherView withOffset:(CGFloat)offset;
		[Export ("autoAlignAxis:toSameAxisOfView:withOffset:")]
		NSLayoutConstraint AutoAlignAxis (ALAxis axis, UIView otherView, float offset);

		// -(NSLayoutConstraint *)autoMatchDimension:(ALDimension)dimension toDimension:(ALDimension)toDimension ofView:(UIView *)otherView;
		[Export ("autoMatchDimension:toDimension:ofView:")]
		NSLayoutConstraint AutoMatchDimension (ALDimension dimension, ALDimension toDimension, UIView otherView);

		// -(NSLayoutConstraint *)autoMatchDimension:(ALDimension)dimension toDimension:(ALDimension)toDimension ofView:(UIView *)otherView withOffset:(CGFloat)offset;
		[Export ("autoMatchDimension:toDimension:ofView:withOffset:")]
		NSLayoutConstraint AutoMatchDimension (ALDimension dimension, ALDimension toDimension, UIView otherView, float offset);

		// -(NSLayoutConstraint *)autoMatchDimension:(ALDimension)dimension toDimension:(ALDimension)toDimension ofView:(UIView *)otherView withOffset:(CGFloat)offset relation:(NSLayoutRelation)relation;
		[Export ("autoMatchDimension:toDimension:ofView:withOffset:relation:")]
		NSLayoutConstraint AutoMatchDimension (ALDimension dimension, ALDimension toDimension, UIView otherView, float offset, NSLayoutRelation relation);

		// -(NSLayoutConstraint *)autoMatchDimension:(ALDimension)dimension toDimension:(ALDimension)toDimension ofView:(UIView *)otherView withMultiplier:(CGFloat)multiplier;
		[Export ("autoMatchDimension:toDimension:ofView:withMultiplier:")]
		NSLayoutConstraint AutoMatchDimensionWithMultiplier (ALDimension dimension, ALDimension toDimension, UIView otherView, float multiplier);

		// -(NSLayoutConstraint *)autoMatchDimension:(ALDimension)dimension toDimension:(ALDimension)toDimension ofView:(UIView *)otherView withMultiplier:(CGFloat)multiplier relation:(NSLayoutRelation)relation;
		[Export ("autoMatchDimension:toDimension:ofView:withMultiplier:relation:")]
		NSLayoutConstraint AutoMatchDimensionWithMultiplier (ALDimension dimension, ALDimension toDimension, UIView otherView, float multiplier, NSLayoutRelation relation);

		// -(NSArray *)autoSetDimensionsToSize:(CGSize)size;
		[Export ("autoSetDimensionsToSize:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] AutoSetDimensionsToSize (SizeF size);

		// -(NSLayoutConstraint *)autoSetDimension:(ALDimension)dimension toSize:(CGFloat)size;
		[Export ("autoSetDimension:toSize:")]
		NSLayoutConstraint AutoSetDimension (ALDimension dimension, float size);

		// -(NSLayoutConstraint *)autoSetDimension:(ALDimension)dimension toSize:(CGFloat)size relation:(NSLayoutRelation)relation;
		[Export ("autoSetDimension:toSize:relation:")]
		NSLayoutConstraint AutoSetDimension (ALDimension dimension, float size, NSLayoutRelation relation);

		// -(void)autoSetContentCompressionResistancePriorityForAxis:(ALAxis)axis;
		[Export ("autoSetContentCompressionResistancePriorityForAxis:")]
		void AutoSetContentCompressionResistancePriorityForAxis (ALAxis axis);

		// -(void)autoSetContentHuggingPriorityForAxis:(ALAxis)axis;
		[Export ("autoSetContentHuggingPriorityForAxis:")]
		void AutoSetContentHuggingPriorityForAxis (ALAxis axis);

		// -(NSLayoutConstraint *)autoConstrainAttribute:(ALAttribute)attribute toAttribute:(ALAttribute)toAttribute ofView:(UIView *)otherView;
		[Export ("autoConstrainAttribute:toAttribute:ofView:")]
		NSLayoutConstraint AutoConstrainAttribute (ALAttribute attribute, ALAttribute toAttribute, UIView otherView);

		// -(NSLayoutConstraint *)autoConstrainAttribute:(ALAttribute)attribute toAttribute:(ALAttribute)toAttribute ofView:(UIView *)otherView withOffset:(CGFloat)offset;
		[Export ("autoConstrainAttribute:toAttribute:ofView:withOffset:")]
		NSLayoutConstraint AutoConstrainAttribute (ALAttribute attribute, ALAttribute toAttribute, UIView otherView, float offset);

		// -(NSLayoutConstraint *)autoConstrainAttribute:(ALAttribute)attribute toAttribute:(ALAttribute)toAttribute ofView:(UIView *)otherView withOffset:(CGFloat)offset relation:(NSLayoutRelation)relation;
		[Export ("autoConstrainAttribute:toAttribute:ofView:withOffset:relation:")]
		NSLayoutConstraint AutoConstrainAttribute (ALAttribute attribute, ALAttribute toAttribute, UIView otherView, float offset, NSLayoutRelation relation);

		// -(NSLayoutConstraint *)autoConstrainAttribute:(ALAttribute)attribute toAttribute:(ALAttribute)toAttribute ofView:(UIView *)otherView withMultiplier:(CGFloat)multiplier;
		[Export ("autoConstrainAttribute:toAttribute:ofView:withMultiplier:")]
		NSLayoutConstraint AutoConstrainAttributeWithMultiplier (ALAttribute attribute, ALAttribute toAttribute, UIView otherView, float multiplier);

		// -(NSLayoutConstraint *)autoConstrainAttribute:(ALAttribute)attribute toAttribute:(ALAttribute)toAttribute ofView:(UIView *)otherView withMultiplier:(CGFloat)multiplier relation:(NSLayoutRelation)relation;
		[Export ("autoConstrainAttribute:toAttribute:ofView:withMultiplier:relation:")]
		NSLayoutConstraint AutoConstrainAttributeWithMultiplier (ALAttribute attribute, ALAttribute toAttribute, UIView otherView, float multiplier, NSLayoutRelation relation);

		// -(NSLayoutConstraint *)autoPinToTopLayoutGuideOfViewController:(UIViewController *)viewController withInset:(CGFloat)inset;
		[Export ("autoPinToTopLayoutGuideOfViewController:withInset:")]
		NSLayoutConstraint AutoPinToTopLayoutGuideOfViewController (UIViewController viewController, float inset);

		// -(NSLayoutConstraint *)autoPinToTopLayoutGuideOfViewController:(UIViewController *)viewController withInset:(CGFloat)inset relation:(NSLayoutRelation)relation;
		[Export ("autoPinToTopLayoutGuideOfViewController:withInset:relation:")]
		NSLayoutConstraint AutoPinToTopLayoutGuideOfViewController (UIViewController viewController, float inset, NSLayoutRelation relation);

		// -(NSLayoutConstraint *)autoPinToBottomLayoutGuideOfViewController:(UIViewController *)viewController withInset:(CGFloat)inset;
		[Export ("autoPinToBottomLayoutGuideOfViewController:withInset:")]
		NSLayoutConstraint AutoPinToBottomLayoutGuideOfViewController (UIViewController viewController, float inset);

		// -(NSLayoutConstraint *)autoPinToBottomLayoutGuideOfViewController:(UIViewController *)viewController withInset:(CGFloat)inset relation:(NSLayoutRelation)relation;
		[Export ("autoPinToBottomLayoutGuideOfViewController:withInset:relation:")]
		NSLayoutConstraint AutoPinToBottomLayoutGuideOfViewController (UIViewController viewController, float inset, NSLayoutRelation relation);

		// -(void)autoRemoveConstraintsAffectingView __attribute__((deprecated("")));
		[Export ("autoRemoveConstraintsAffectingView")]
		void AutoRemoveConstraintsAffectingView ();

		// -(void)autoRemoveConstraintsAffectingViewIncludingImplicitConstraints:(BOOL)shouldRemoveImplicitConstraints __attribute__((deprecated("")));
		[Export ("autoRemoveConstraintsAffectingViewIncludingImplicitConstraints:")]
		void AutoRemoveConstraintsAffectingViewIncludingImplicitConstraints (bool shouldRemoveImplicitConstraints);

		// -(void)autoRemoveConstraintsAffectingViewAndSubviews __attribute__((deprecated("")));
		[Export ("autoRemoveConstraintsAffectingViewAndSubviews")]
		void AutoRemoveConstraintsAffectingViewAndSubviews ();

		// -(void)autoRemoveConstraintsAffectingViewAndSubviewsIncludingImplicitConstraints:(BOOL)shouldRemoveImplicitConstraints __attribute__((deprecated("")));
		[Export ("autoRemoveConstraintsAffectingViewAndSubviewsIncludingImplicitConstraints:")]
		void AutoRemoveConstraintsAffectingViewAndSubviewsIncludingImplicitConstraints (bool shouldRemoveImplicitConstraints);
	}

	// @interface PureLayout (NSArray)
	[Category]
	[BaseType (typeof(NSArray))]
	interface NSArray_PureLayout
	{
		// -(void)autoInstallConstraints;
		[Export ("autoInstallConstraints")]
		void AutoInstallConstraints ();

		// -(void)autoRemoveConstraints;
		[Export ("autoRemoveConstraints")]
		void AutoRemoveConstraints ();

		// -(instancetype)autoIdentifyConstraints:(NSString *)identifier;
		[Export ("autoIdentifyConstraints:")]
		NSArray AutoIdentifyConstraints (string identifier);

		// -(NSArray *)autoAlignViewsToEdge:(ALEdge)edge;
		[Export ("autoAlignViewsToEdge:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] AutoAlignViewsToEdge (ALEdge edge);

		// -(NSArray *)autoAlignViewsToAxis:(ALAxis)axis;
		[Export ("autoAlignViewsToAxis:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] AutoAlignViewsToAxis (ALAxis axis);

		// -(NSArray *)autoMatchViewsDimension:(ALDimension)dimension;
		[Export ("autoMatchViewsDimension:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] AutoMatchViewsDimension (ALDimension dimension);

		// -(NSArray *)autoSetViewsDimension:(ALDimension)dimension toSize:(CGFloat)size;
		[Export ("autoSetViewsDimension:toSize:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] AutoSetViewsDimension (ALDimension dimension, float size);

		// -(NSArray *)autoSetViewsDimensionsToSize:(CGSize)size;
		[Export ("autoSetViewsDimensionsToSize:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] AutoSetViewsDimensionsToSize (SizeF size);

		// -(NSArray *)autoDistributeViewsAlongAxis:(ALAxis)axis alignedTo:(ALAttribute)alignment withFixedSpacing:(CGFloat)spacing;
		[Export ("autoDistributeViewsAlongAxis:alignedTo:withFixedSpacing:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] AutoDistributeViewsAlongAxis (ALAxis axis, ALAttribute alignment, float spacing);

		// -(NSArray *)autoDistributeViewsAlongAxis:(ALAxis)axis alignedTo:(ALAttribute)alignment withFixedSpacing:(CGFloat)spacing insetSpacing:(BOOL)shouldSpaceInsets;
		[Export ("autoDistributeViewsAlongAxis:alignedTo:withFixedSpacing:insetSpacing:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] AutoDistributeViewsAlongAxis (ALAxis axis, ALAttribute alignment, float spacing, bool shouldSpaceInsets);

		// -(NSArray *)autoDistributeViewsAlongAxis:(ALAxis)axis alignedTo:(ALAttribute)alignment withFixedSpacing:(CGFloat)spacing insetSpacing:(BOOL)shouldSpaceInsets matchedSizes:(BOOL)shouldMatchSizes;
		[Export ("autoDistributeViewsAlongAxis:alignedTo:withFixedSpacing:insetSpacing:matchedSizes:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] AutoDistributeViewsAlongAxis (ALAxis axis, ALAttribute alignment, float spacing, bool shouldSpaceInsets, bool shouldMatchSizes);

		// -(NSArray *)autoDistributeViewsAlongAxis:(ALAxis)axis alignedTo:(ALAttribute)alignment withFixedSize:(CGFloat)size;
		[Export ("autoDistributeViewsAlongAxis:alignedTo:withFixedSize:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] AutoDistributeViewsAlongAxisWithSize (ALAxis axis, ALAttribute alignment, float size);

		// -(NSArray *)autoDistributeViewsAlongAxis:(ALAxis)axis alignedTo:(ALAttribute)alignment withFixedSize:(CGFloat)size insetSpacing:(BOOL)shouldSpaceInsets;
		[Export ("autoDistributeViewsAlongAxis:alignedTo:withFixedSize:insetSpacing:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] AutoDistributeViewsAlongAxisWithSize (ALAxis axis, ALAttribute alignment, float size, bool shouldSpaceInsets);
	}

	// @interface PureLayout (NSLayoutConstraint)
	[Category]
	[BaseType (typeof(NSLayoutConstraint))]
	interface NSLayoutConstraint_PureLayout
	{
		// -(void)autoInstall;
		[Export ("autoInstall")]
		void AutoInstall ();

		// -(void)autoRemove;
		[Export ("autoRemove")]
		void AutoRemove ();

		// -(instancetype)autoIdentify:(NSString *)identifier;
		[Export ("autoIdentify:")]
		NSLayoutConstraint AutoIdentify (string identifier);
	}

	// @interface PureLayoutInternal (UIView)
	// Kashif: Removed PureLayoutInternal interface
}
